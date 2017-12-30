﻿using LifeLine.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LifeLine.Infrastructure
{
    public class BloodDonorInitalizeDb : DropCreateDatabaseIfModelChanges<BloodDonorContext>
    {

        protected override void Seed(BloodDonorContext context)
        {
            context.BloodDonors.Add(
            new BloodDonor
            {
                Name = "Rahul Kapoor",
                City = "Gurgaon",
                BloodGroup = "A+",
                BloodDonorID = "BD1",
                Country = "India",
                IsActive = true,
                IsPrivate = false,
                IsVerified = true,
                PhoneNumber = "91+7378388383",
                PinCode = 122002,
                Email = "Rahul@abc.com"

            });
            context.BloodDonors.Add(
            new BloodDonor
            {
                Name = "Salman Khan",
                City = "Mumbai",
                BloodGroup = "A-",
                BloodDonorID = "BD2",
                Country = "India",
                IsActive = true,
                IsPrivate = false,
                IsVerified = true,
                PhoneNumber = "91+84848484",
                PinCode = 25678,
                Email = "Salman@abc.com"
            });
            base.Seed(context);
        }
    }
}