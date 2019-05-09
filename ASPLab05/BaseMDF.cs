namespace ASPLab05
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BaseMDF : DbContext
    {
        public BaseMDF()
            : base("name=BaseMDF")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
