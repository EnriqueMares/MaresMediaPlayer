using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace MaresMediaPlayerKaraoke
{
    public class Canciones
    {
        //Atributos
        private List<Cancion> lista = new List<Cancion>();



        //Propiedades
        public List<Cancion> Lista
        {
            get { return lista; }
            set { lista = value; }
        }


        //Metodos
        public void Guardar(string ruta, List<Cancion> lista)
        {
            List<Cancion> listaDeGobernantes = lista;
            try
            {
                //Guardar
                FileStream fs = new FileStream(ruta, FileMode.Create);
                //XmlTextWriter escritor = new XmlTextWriter(ruta, Encoding.UTF8);
                //escritor.Formatting = Formatting.Indented;
                XmlSerializer serializador = new XmlSerializer(typeof(List<Cancion>));
                serializador.Serialize(fs, lista);
                fs.Close();
            }
            catch (Exception e)
            {

            }
        }
        public static List<Cancion> Cargar(string ruta)
        {
            List<Cancion> listaDeCanciones;
            XmlTextReader lector = new XmlTextReader(ruta);
            XmlSerializer serializador = new XmlSerializer(typeof(List<Cancion>));
            listaDeCanciones = (List<Cancion>)serializador.Deserialize(lector);
            lector.Close();

            //Para asegurar que nunca falle, por si no existe la lista
            if (listaDeCanciones == null)
            {
               // listaDeCanciones = new Canciones();
            }
            return listaDeCanciones;
        }

    }
}
