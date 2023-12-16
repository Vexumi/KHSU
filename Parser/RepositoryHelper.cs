using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Parser.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    public static class RepositoryHelper
    {
        public async static Task SaveExperiment(ApplicationContext context, Experiment experiment)
        {
            var oldExperiment = await context.Experiments.Where(ex => ex.Name == experiment.Name).FirstOrDefaultAsync();

            if (oldExperiment is null) // if exeriment doesnt exist
            {
                context.Experiments.Add(experiment);

            }
            else // if experiment exist
            {
                experiment.Id = oldExperiment.Id;

                context.Experiments.Attach(experiment);
                context.Experiments.Entry(experiment).State = EntityState.Modified;
            }

            await context.SaveChangesAsync();
        }
    }
}
