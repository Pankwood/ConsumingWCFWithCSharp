#region Licence
//===================================================================================
// Pankwood
//===================================================================================
// Copyright (c) 2016, Pankwood.  All Rights Reserved.
//===================================================================================
#endregion

#region References
using System.Collections.Generic;
using System.Net;
using System.Runtime.Serialization.Json;
#endregion

public class Client
{
    public static List<City> MyList()  
    {
        //Initializes a new WebRequest instance for the specified URI scheme.
        WebRequest request = WebRequest.Create("https://webservices.mmtgapnet.com.br/Service/Cidades.svc/Cidade/673b5bfd-396e-4179-8g52-1f5d97aba3bd");
        //Returns a response from an Internet resource.
        WebResponse ws = request.GetResponse();
        //Deserialize the string and transform in memory object
        DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(ListCity));
        //Read the object in memory and casting to class
        ListCity response = (ListCity)jsonSerializer.ReadObject(ws.GetResponseStream());
        //Return a DataSource
        return response.CidadeResult;
    }

}