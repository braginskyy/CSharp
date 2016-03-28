using ISD_13.Data;
using System;
using System.Collections.Generic;
using ISD_13.Repository.Interfaces;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_13.Repository
{
    class ProfileRepository : Repository<Profile>, IProfileRepository
    {
        public ProfileRepository(Context db)
            : base(db)
        {
        }
    }
}
