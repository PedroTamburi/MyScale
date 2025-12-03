using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyScale.Domain.Responses;

public sealed record AddressLookupResult(
    string Street,
    string Neighborhood,
    string CityName,
    string StateAcronym,
    string StateName
);