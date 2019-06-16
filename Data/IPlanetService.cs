using System.Collections.Generic;
using PlanetAtlas.Models;

namespace PlanetAtlas.Data
{
    interface IPlanetService
    {
        IEnumerable<Planet> GetPlanets(string filter = null);

        bool AddPlanet(Planet planet, out bool success);

        bool UpdatePlanet(string name, Planet editPlanet, out bool success);
    }
}
