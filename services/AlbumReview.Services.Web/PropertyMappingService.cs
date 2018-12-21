﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace AlbumReview.Services.Web
{
    public class PropertyMappingService : IPropertyMappingService
    {
        private readonly Dictionary<string, PropertyMappingValue> _artistPropertyMapping = new Dictionary<string, PropertyMappingValue>(StringComparer.OrdinalIgnoreCase)
        {
            { "Id", new PropertyMappingValue(new List<string>() { "Id" })},
            { "StageName", new PropertyMappingValue(new List<string>() { "StageName" })},
            { "Age", new PropertyMappingValue(new List<string>() { "DateOfBirth" })},
            { "Name", new PropertyMappingValue(new List<string>() { "FirstName", "LastName" })}
        };

        private readonly Dictionary<string, PropertyMappingValue> _reviewPropertyMapping = new Dictionary<string, PropertyMappingValue>(StringComparer.OrdinalIgnoreCase)
        {
            { "Id", new PropertyMappingValue(new List<string>() { "Id" })},
            { "SubmittedReview", new PropertyMappingValue(new List<string>() { "SubmittedReview" })},
            { "Rating", new PropertyMappingValue(new List<string>() { "Rating" })},
            { "Submitted", new PropertyMappingValue(new List<string>() { "Submitted" })}
        };

        private IList<IPropertyMapping> propertyMappings = new List<IPropertyMapping>();
        
        public void AddPropertyMapping<TSource, TDestination>(Dictionary<string, PropertyMappingValue> mapping)
        {
            propertyMappings.Add(new PropertyMapping<TSource, TDestination>(mapping));
        }

        public void AddArtistPropertyMapping<TSource, TDestination>()
        {
            propertyMappings.Add(new PropertyMapping<TSource, TDestination>(_artistPropertyMapping));
        }

        public void AddReviewPropertyMapping<TSource, TDestination>()
        {
            propertyMappings.Add(new PropertyMapping<TSource, TDestination>(_reviewPropertyMapping));
        }

        public Dictionary<string, PropertyMappingValue> GetPropertyMapping<TSource, TDestination>()
        {
            var matchingMapping = propertyMappings.OfType<PropertyMapping<TSource, TDestination>>();

            if (matchingMapping.Count() == 1)
            {
                return matchingMapping.First()._mappingDictionary;
            }

            throw new Exception($"Can't find property mapping instance for <{typeof(TSource)}>");
        }

        public bool validMappingExistsFor<TSource, TDestination>(string fields)
        {
            var propertyMapping = GetPropertyMapping<TSource, TDestination>();

            if (string.IsNullOrWhiteSpace(fields))
            {
                return true;
            }

            //  split the strong by ","
            var fieldsAfterSplit = fields.Split(",");

            foreach (var field in fieldsAfterSplit)
            {
                //  trim
                var trimmedField = field.Trim();

                //  remove everything after the first " "
                //  if the fields are coming from an orderBy string
                //  this part must be ignored
                var indexOfFirstSpace = trimmedField.IndexOf(" ");
                var propertyName = indexOfFirstSpace == -1 ? trimmedField : trimmedField.Remove(indexOfFirstSpace);

                //  find the matching property
                if (!propertyMapping.ContainsKey(propertyName))
                {
                    return false;
                }
            }
            return true;
        }
    }
}