using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSM.Data.Models;
using MSM.Data.Repositories.Interfaces;
using MSMEnumerations;
using Microsoft.EntityFrameworkCore;
using MSM.Data.PresentationModel;
using System.Data.SqlClient;
using System.Data;
using MSM.Data.Helpers;

namespace MSM.Data.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="MSM.Data.EntityBaseRepository{MSM.Data.Models.Site}" />
    /// <seealso cref="MSM.Data.Repositories.Interfaces.ISiteRepository" />
    public class SiteRepository : EntityBaseRepository<Site>, ISiteRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SiteRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public SiteRepository(Func<MultisiteDBEntitiesContext> context)
            : base(context)
        { }

        /// <summary>
        /// Gets the site list filtered.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="siteName">Name of the site.</param>
        /// <returns></returns>
        public async Task<IQueryable<Site>> GetSiteListFiltered(int filter, string siteName)
        {
            //var sites = this.Context.Site.Include(".Parent.*");
            var sites = this.AllIncluding(s => s.Parent.Parent.Parent);
            if (!string.IsNullOrEmpty(siteName) && !siteName.Equals("all"))
            {
                sites = sites.Where(s => s.Description.Contains(siteName));
            }

            if (filter.Equals((int)FilterTypeEnum.all))
            {
                return sites;
            }

            if (filter.Equals((int)FilterTypeEnum.hasSolar))
            {
                return await Task.FromResult(from s in sites
                                             from templ in this.Context.Set<SiteTemplate>()
                                             where s.TemplateId == templ.TemplateId && templ.Solar
                                             select s);
            }

            if (filter.Equals((int)FilterTypeEnum.hasGenerator))
            {
                return await Task.FromResult(from s in sites
                                             from templ in this.Context.Set<SiteTemplate>()
                                             where s.TemplateId == templ.TemplateId && templ.Generator
                                             select s);
            }

            if (filter.Equals((int)FilterTypeEnum.hasWind))
            {
                return await Task.FromResult(from s in sites
                                             from templ in this.Context.Set<SiteTemplate>()
                                             where s.TemplateId == templ.TemplateId && templ.Wind
                                             select s);
            }

            // Hybrid filters
            if (filter.Equals((int)FilterTypeEnum.hybrid))
            {
                return await Task.FromResult(from s in sites
                                             from templ in this.Context.Set<SiteTemplate>()
                                             where s.TemplateId == templ.TemplateId && !templ.OnGrid
                                             select s);
            }

            if (filter.Equals((int)FilterTypeEnum.hybridGen))
            {
                return await Task.FromResult(from s in sites
                                             from templ in this.Context.Set<SiteTemplate>()
                                             where s.TemplateId == templ.TemplateId && !templ.OnGrid && templ.Generator
                                             select s);

            }

            if (filter.Equals((int)FilterTypeEnum.hybridPV))
            {
                return await Task.FromResult(from s in sites
                                             from templ in this.Context.Set<SiteTemplate>()
                                             where s.TemplateId == templ.TemplateId && !templ.OnGrid && templ.Solar
                                             select s);
            }

            if (filter.Equals((int)FilterTypeEnum.hybridWind))
            {
                return await Task.FromResult(from s in sites
                                             from templ in this.Context.Set<SiteTemplate>()
                                             where s.TemplateId == templ.TemplateId && !templ.OnGrid && templ.Wind
                                             select s);
            }

            if (filter.Equals((int)FilterTypeEnum.hasMainsMonitorHybrid))
            {
                return await Task.FromResult(from s in sites
                                             from templ in this.Context.Set<SiteTemplate>()
                                             where s.TemplateId == templ.TemplateId && !templ.OnGrid && templ.MainsMonitor
                                             select s);
            }

            // Grid filters
            if (filter.Equals((int)FilterTypeEnum.onGrid))
            {
                return await Task.FromResult(from s in sites
                                             from templ in this.Context.Set<SiteTemplate>()
                                             where s.TemplateId == templ.TemplateId && templ.OnGrid
                                             select s);
            }

            if (filter.Equals((int)FilterTypeEnum.onGridGen))
            {
                return await Task.FromResult(from s in sites
                                             from templ in this.Context.Set<SiteTemplate>()
                                             where s.TemplateId == templ.TemplateId && templ.OnGrid && templ.Generator
                                             select s);
            }

            if (filter.Equals((int)FilterTypeEnum.onGridPV))
            {
                return await Task.FromResult(from s in sites
                                             from templ in this.Context.Set<SiteTemplate>()
                                             where s.TemplateId == templ.TemplateId && templ.OnGrid && templ.Solar
                                             select s);
            }

            if (filter.Equals((int)FilterTypeEnum.onGridWind))
            {
                return await Task.FromResult(from s in sites
                                             from templ in this.Context.Set<SiteTemplate>()
                                             where s.TemplateId == templ.TemplateId && templ.OnGrid && templ.Wind
                                             select s);
            }

            if (filter.Equals((int)FilterTypeEnum.hasMainsMonitorGrid))
            {
                return await Task.FromResult(from s in sites
                                             from templ in this.Context.Set<SiteTemplate>()
                                             where s.TemplateId == templ.TemplateId && templ.OnGrid && templ.MainsMonitor
                                             select s);
            }

            if (filter.Equals((int)FilterTypeEnum.hasAlarm))
            {
                return await Task.FromResult(from s in sites
                                             where (s.Status == 3 || s.Status == 7 || s.Status == 8 || s.Status == 10 || s.Status == 2 || s.Status == 9 || s.Status == 11)
                                             select s);
            }

            if (filter.Equals((int)FilterTypeEnum.isOffline))
            {
                return await Task.FromResult(from s in sites
                                             where s.Status == 5
                                             select s);
            }

            return sites;
        }

        /// <summary>
        /// Gets the sites ListView.
        /// </summary>
        /// <param name="siteIds">The site ids.</param>
        /// <param name="pageIndex">Index of the page.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns></returns>
        public async Task<IEnumerable<SiteListViewDTO>> GetSitesListView(List<int> siteIds, int pageIndex, int pageSize)
        {
            using (var connection = this.Context.Database.GetDbConnection())
            {
                using (var command = new SqlCommand())
                {
                    string connectionStr = connection.ConnectionString;
                    connectionStr += ";Password=123456@Xyz";
                    SqlConnection msmConnection = new SqlConnection(connectionStr);
                    if (msmConnection.State != ConnectionState.Open)
                    {
                        await msmConnection.OpenAsync();
                    }

                    command.Connection = msmConnection;
                    command.CommandText = "sp_GetListView";
                    command.CommandType = CommandType.StoredProcedure;
                    string str = string.Empty;
                    if (siteIds == null || siteIds.Count == 0)
                    {
                        await (await this.GetAll()).ForEachAsync(s => str += s.Id + ",");
                    }
                    else
                    {
                        siteIds.ForEach(s => str += s + ",");
                    }

                    command.Parameters.Add(new SqlParameter("@siteids", str));

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        return reader.MapToList<SiteListViewDTO>().Skip(pageIndex * pageSize).Take(pageSize);
                    }
                }
            }
        }

        public int GetLastSiteID()
        {
            return (from siteTemp in this.Context.Site
                                orderby siteTemp.Id descending
                                select siteTemp.Id).FirstOrDefault();
        }

        public IQueryable<Site> GetSiteByIds(IQueryable<int> ids)
        {
            return this.FindBy(s => ids.Contains(s.Id));
        }

        public IQueryable<Site> GetParentSites()
        {
            return this.FindBy(s => string.IsNullOrEmpty(s.Address));
        }
    }
}
