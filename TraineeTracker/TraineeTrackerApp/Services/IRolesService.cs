using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace TraineeTrackerApp.Services
{
    public interface IRolesService
    {
        Task<IEnumerable<IdentityRole>> GetRoles();
    }
}
