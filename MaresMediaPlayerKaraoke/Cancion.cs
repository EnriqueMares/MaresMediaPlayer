using System;
using System.Collections.Generic;
using System.Text;

namespace MaresMediaPlayerKaraoke
{
    public class Cancion
    {
        //Atributos
        private string nombre;
        private string artista;   
        private string genero;
        private int minutos;     
        private int segundos;
        private int duracion;
        private string album;
        private string ruta_Artista;   
        private string ruta_Disco;    
        private string ruta_Letra;
        private string ruta_Cancion;
        private string ruta_Biografia;

            
        //Propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Artista
        {
            get { return artista; }
            set { artista = value; }
        }

        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public int Minutos
        {
            get { return minutos; }
            set { minutos = value; }
        }

        public int Segundos
        {
            get { return segundos; }
            set { segundos = value; }
        }

        public int Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }

        public string Album
        {
            get { return album; }
            set { album = value; }
        }

        public string Ruta_Artista
        {
            get { return ruta_Artista; }
            set { ruta_Artista = value; }
        }

        public string Ruta_Disco
        {
            get { return ruta_Disco; }
            set { ruta_Disco = value; }
        }


        public string Ruta_Letra
        {
            get { return ruta_Letra; }
            set { ruta_Letra = value; }
        }

        public string Ruta_Cancion
        {
            get { return ruta_Cancion; }
            set { ruta_Cancion = value; }
        }

        public string Ruta_Biografia
        {
            get { return ruta_Biografia; }
            set { ruta_Biografia = value; }
        }
	
        //Metodos
    }
}
