using AutoMapper;
using SharedEntities.Models.DTO.Response;
using UesrServices.Models;
using UserEntities.Entities;

namespace UesrServices.Helpers;

public static class BandHelper
{
    public static BandResponse Create(BandDto rules, BandEntity? entity = null)
    {
        var response = new BandResponse();

        if (entity != null)
        {
            
        }
        else
        {
            
        }

        response.Units = rules.Units;
        response.Rules = rules.Rules;

        return response;
    }
}