using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using DataLayer.Entity;
using DataLayer.Data;
using Microsoft.EntityFrameworkCore;

namespace ServiceLayer
{ 
    public class JobService 
    {
        private readonly MosaicContext ctx;
    

        public List<Job> Jobs;

        public JobService(MosaicContext context)
        {
            ctx = context;
        }
        // this is the most critical query
        public Job GetDeepJob(int jobID)
        {
            return ctx.Job.Include(s => s.Product).ThenInclude(s => s.SubAssemblies).Where(j => j.jobID == jobID).FirstOrDefault();
        }

        public void AddOrUpdateJob()
        {

        }

        public Job FindJob(int jobID)
        {
            return ctx.Job.Find(jobID);
        }
        /// <summary>
        /// Return list of 25 most recent Jobs
        /// </summary>
        /// <returns></returns>
        public List<JobListDto> RecentJobs()
        {
            var jobs = ctx.Job.AsNoTracking().OrderByDescending(r => r.start_ts).Select(d => new JobListDto
            {
                JobID = d.jobID,
                JobName = d.jobname
            }).Take(120).ToList();
            return jobs;
        }

        public List<Job> SearchJobs(string term)
        {
            return ctx.Job.Where(w => w.jobname.Contains(term)).ToList();
        }

        

    }
}
