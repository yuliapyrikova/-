using pyrikova.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace pyrikova.Repository
{
    public PersonalData Create(PersonalData personalData)
    {
        // var id = _personalDatas.Keys.Last() + 1;
        var id = _personalDatas.Keys.Max() + 1;
        personalData.Id = id;
        _personalDatas.Add(personalData.Id, personalData);
        return personalData;
        //var command = PersonalData.CreateCommand();
        //command.CommandText = "SELECT * FROM .....";
        //command.ExecuteNonQuery
        //command.ExecuteReader
        //command.ExecuteScalar
    }

    public PersonalData Read(int id)
        {
            return PersonalDatas[id];
        }
    }
}