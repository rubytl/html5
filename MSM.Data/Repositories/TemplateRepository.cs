using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MSM.Data.Models;
using MSM.Data.Repositories.Interfaces;
using System.Linq;

namespace MSM.Data.Repositories
{
    public class TemplateRepository : EntityBaseRepository<SiteTemplate>, ITemplateRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public TemplateRepository(Func<MultisiteDBEntitiesContext> context)
            : base(context)
        { }

        /// <summary>
        /// Gets the sites ListView.
        /// </summary>
        /// <param name="siteIds">The site ids.</param>
        /// <param name="pageIndex">Index of the page.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns></returns>
        public async Task<IEnumerable<SiteTemplate>> GetSiteTemplates(int pageIndex, int pageSize)
        {
            return (await this.GetAll()).Skip(pageIndex * pageSize).Take(pageSize);
        }

        public string GetLastTemplateID()
        {
            string myLastTemplateID = (from siteTemp in this.Context.SiteTemplate
                                       orderby siteTemp.TemplateId descending
                                       select siteTemp.TemplateId).FirstOrDefault();
            try
            {
                var result = (int.Parse(myLastTemplateID) + 1).ToString("0000");
                return result;
            }
            catch
            {
                return "0001";
            }
        }
    }
}
