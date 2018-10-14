﻿using AlbumsReviewRESTApi.Entities;
using AlbumsReviewRESTApi.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumsReviewRESTApi.filters
{
    public class ArtistResultFilterAttribute : ResultFilterAttribute
    {
        public async override Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            //  get the result returned from the controller action
            var resultFromControllerAction = context.Result as ObjectResult;

            if (resultFromControllerAction?.Value == null
                || resultFromControllerAction.StatusCode < 200
                || resultFromControllerAction.StatusCode >= 300)
            {
                await next();
                return;
            }


            //  map the artist POCO to artist DTO
            //  and set it to the result from the controller action value
            if (resultFromControllerAction.Value is IEnumerable<Artist>)
            {
                resultFromControllerAction.Value = Mapper.Map<IEnumerable<ArtistDto>>(resultFromControllerAction.Value);
            }
            else
            {
                resultFromControllerAction.Value = Mapper.Map<ArtistDto>(resultFromControllerAction.Value);
            }
            

            await next();
        }
    }
}
