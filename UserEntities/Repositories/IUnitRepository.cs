using SharedServices;
using UserEntities.Entities;
using UserEntities.Models;

namespace UserEntities.Repositories;

public interface IUnitRepository : IRepository<UnitEntity, UnitFilter> { }