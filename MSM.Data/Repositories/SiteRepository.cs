using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSM.Data.Models;
using MSM.Data.Repositories.Interfaces;
using MSMEnumerations;
using Microsoft.EntityFrameworkCore;

namespace MSM.Data.Repositories
{
    public class SiteRepository : EntityBaseRepository<Site>, ISiteRepository
    {
        public SiteRepository(Func<MultisiteDBEntitiesContext> context)
            : base(context)
        { }

        public async Task<IQueryable<Site>> GetSiteListFiltered(int filter, string siteName)
        {
            //var sites = this.Context.Site.Include(".Parent.*");
            var sites = await this.AllIncluding(s => s.Parent.Parent.Parent);
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
    }
}
