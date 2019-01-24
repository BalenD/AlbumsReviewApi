﻿using System;

namespace AlbumReview.Web.Api.Helpers
{
    public static class DatetimeOffsetExtensions
    {
        public static int CalculateAge(this DateTimeOffset datetimeOffset)
        {

            var currentDate = DateTime.UtcNow;


            int age = currentDate.Year - datetimeOffset.Year;

            return age;
        }
    }
}
