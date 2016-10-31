using Monster.App.DataAcess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Monster.App.DataAcess
{
    /// <summary>
    /// 
    /// </summary>
    [ServiceContract]
    public interface IMonsterService
    {
        [OperationContract()]
        List<GenderDAO> GetGender();

        [OperationContract()]
        List<MonsterTypeDAO> GetMonsterTypes();

        [OperationContract()]
        List<TitleDAO> GetTitles();

    }
}
