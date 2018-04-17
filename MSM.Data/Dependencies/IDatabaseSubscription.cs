using System;
using System.Collections.Generic;
using System.Text;

namespace MSM.Data.Dependencies
{
    public interface IDatabaseSubscription
    {
        void Configure(string connectionString);
    }
}
