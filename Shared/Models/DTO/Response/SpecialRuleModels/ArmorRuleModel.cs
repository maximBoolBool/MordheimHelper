﻿namespace RuleServices.Models.SpecialRuleModels;

public class ArmorRuleModel : BaseSpecialRuleModel
{
    public long Id { get; set; }
    
    public string Name { get; set; }
    
    public string Description { get; set; }
}