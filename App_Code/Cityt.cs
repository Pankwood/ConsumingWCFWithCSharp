#region Licence
//===================================================================================
// Pankwood
//===================================================================================
// Copyright (c) 2016, Pankwood.  All Rights Reserved.
//===================================================================================
#endregion

#region References
using System.Collections.Generic;
#endregion

public class ListCity
{
    //List of fields and values
    public List<City> CidadeResult { get; set; }
}

public class City
{
    //Fields of data
    public string Cod_Cidade { get; set; }
    public string NomeCidade { get; set; }
}