using Microsoft.EntityFrameworkCore;
using Parser.Model;

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

        public async static Task AddUser(ApplicationContext context, UserModel user)
        {
            var oldUser = await context.Users.Where(u => u.Username == user.Username).FirstOrDefaultAsync();

            if (oldUser is null) // if exeriment doesnt exist
            {
                context.Users.Add(user);

            }
            else // if experiment exist
            {
                user.Id = oldUser.Id;

                context.Users.Attach(user);
                context.Users.Entry(user).State = EntityState.Modified;
            }

            await context.SaveChangesAsync();
        }

        public async static Task<UserModel> GetUser(ApplicationContext context, string username, string password)
        {
            var user = await context.Users.FirstOrDefaultAsync(u => u.Username == username && u.Password == password);

            return user;
        }
    }
}
