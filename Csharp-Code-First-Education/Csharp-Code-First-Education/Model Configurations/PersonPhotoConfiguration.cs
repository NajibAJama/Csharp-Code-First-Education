﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Csharp_Code_First_Education.Model_Configurations
{
    class PersonPhotoConfiguration:EntityTypeConfiguration<PersonPhoto>
    {
        public PersonPhotoConfiguration()
        {
            //HasOptional(p => p.PhotoOf).WithRequired(p => p.Photo);
            HasRequired(p => p.PhotoOf).WithOptional(p => p.Photo);
            HasKey(p => p.PersonId);
        }

    }
}
