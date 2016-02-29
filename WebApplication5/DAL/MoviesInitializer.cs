using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplication5.Models;

namespace WebApplication5.DAL
{
    public class MoviesInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MoviesContext>
    {
    }
}