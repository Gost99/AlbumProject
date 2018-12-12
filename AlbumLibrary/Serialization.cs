using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;

//предусловия постусловия сайд ефекти

namespace AlbumLibrary
{
    public class Serializer<T> : IJSONSerializer, IXMLSerializer
    {
        public Serializer()
        {
            
        }

        public static SerializationType CurrentType { get; private set; }
        

        void IJSONSerializer.Serialize(List<User> listToSerialize, string filePath)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<T>));

            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, listToSerialize);
            }

            
        }

        void IJSONSerializer.Deserialize(out List<User> listToSerialize, string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<T>));
                listToSerialize = (List<User>)jsonFormatter.ReadObject(fs);
            }
            CurrentType = SerializationType.JSON;
        }

        void IXMLSerializer.Serialize(List<User> listToSerialize, string filePath)
        {
            DataContractSerializer dcs = new DataContractSerializer(typeof(List<T>));
            XmlWriter xmlw = XmlWriter.Create(filePath);
            dcs.WriteObject(xmlw, listToSerialize);
            xmlw.Close();
            
        }

        void IXMLSerializer.Deserialize(out List<User> listToSerialize, string filePath)
        {
            DataContractSerializer dcs = new DataContractSerializer(typeof(List<T>));
            XmlReader xmlr = XmlReader.Create(filePath);
            listToSerialize = (List<User>)dcs.ReadObject(xmlr);
            xmlr.Close();
            CurrentType = SerializationType.XML;
        }
    }
    public interface IJSONSerializer
    {
        void Serialize(List<User> toSerializeList, string filePath);
        void Deserialize(out List<User> toSerializeList, string filePath);
    }

    public interface IXMLSerializer
    {
        void Serialize(List<User> toSerializeList, string filePath);
        void Deserialize(out List<User> toSerializeList, string filePath);
    }
}
