using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace MVVM
{
    class JsonFileService:IFileService
    {
        public List<Phone>Open(string filename)
        {
            List<Phone> phones = new List<Phone>();
            DataContractJsonSerializer jsonFaramatter=new DataContractJsonSerializer(typeof(Phone));
            using (FileStream fs = new FileStream (filename, FileMode.OpenOrCreate))
            {
                phones=jsonFaramatter.ReadObject(fs) as List<Phone>;
            }
            return phones;
        }
        public void Save(string filename, List<Phone> phoneList)
        {
            DataContractJsonSerializer jsonFaramatter = new DataContractJsonSerializer(typeof(Phone));
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                jsonFaramatter.WriteObject(fs, phoneList);
            }
            
        }
    }
}
