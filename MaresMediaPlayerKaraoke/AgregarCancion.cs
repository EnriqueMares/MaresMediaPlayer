using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using AxWMPLib;
using System.Media;

namespace MaresMediaPlayerKaraoke
{
    public partial class AgregarCancion : Form
    {        
        #region Constructores
        public AgregarCancion()
        {
            InitializeComponent();
        }

        public AgregarCancion(FileInfo cancion)
        {            
            InitializeComponent();
            LimpiarTodo();
            cancionRaza = cancion;
            rutaArchivo = cancion.FullName;
            txtUbicacion.Text = rutaArchivo;
            txtCancion.Text = cancion.Name.Substring(0,cancion.Name.Length-4);

            axWmpReproductor.URL = cancion.FullName;
            tmEscuchar.Start();
           //axWmpReproductor.Ctlcontrols.currentPosition = 5;

            
        /*    AxWindowsMediaPlayer reproductor=new AxWindowsMediaPlayer();
            reproductor.URL = cancion.FullName;
            txtDuracion.Text = reproductor.Ctlcontrols.currentItem.duration.ToString();            */
        }
        #endregion
        #region Variables
        string rutaArchivo;
        List<Cancion> listaNuevaDeCanciones;
        List<Cancion> listaDeCanciones= new List<Cancion>();
        FileInfo cancionRaza;        
#endregion
        #region Metodos            
        public void LimpiarTodo()
        {
            txtArtista.Clear();
            txtCancion.Clear();
            txtCaratula.Clear();
            txtDisco.Clear();
            txtImagenArtista.Clear();
            txtLyrics.Clear();
            txtUbicacion.Clear();
            rctLetra.Clear();
            rctBiografia.Clear();
            pctArtista.Image = System.Drawing.Image.FromFile(@"..\..\..\Imagenes\Inicial.jpg");
            pctCaratula.Image = System.Drawing.Image.FromFile(@"..\..\..\Imagenes\Inicial.jpg");
            txtImagenArtista.Text = @"..\..\..\Imagenes\Inicial.jpg";
            txtCaratula.Text = @"..\..\..\Imagenes\Inicial.jpg";
            txtLyrics.Text=@"..\..\..\Lyrics\LyricDefault.xml";
            rctLetra.Text = "No se encontro Letra";
            rctBiografia.Text = "No se encontro Biografia";
            txtBiografia.Text = @"..\..\..\Biografias\BiografiaDefault.txt";
        }
        public void SacarEtiquetasMp3(String ruta)
        {
            FileInfo mp3 = new FileInfo(ruta);
            if (mp3.Length > 0)
            {
                FileStream fs=new FileStream(ruta, FileMode.Open);
                byte[] buffer = new byte[128];
                fs.Seek(-128, SeekOrigin.End);
                fs.Read(buffer, 0, 128);
                fs.Close();

                Encoding enc = new ASCIIEncoding();
                string id3 = enc.GetString(buffer);

                if (id3.Substring(0, 3).Equals("TAG"))
                {
                    txtCancion.Text = id3.Substring(3, 30).TrimEnd();
                    txtArtista.Text = id3.Substring(33, 30).TrimEnd();
                    txtDisco.Text=id3.Substring(63, 30).TrimEnd();
                    txtUbicacion.Text=cancionRaza.FullName;                    
                }

                else
                {
                    MessageBox.Show("No tag", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion 
#region Eventos de los Botones
        private void btnLyrics_Click(object sender, EventArgs e)
        {
            OpenFileDialog lyrics = new OpenFileDialog();
            lyrics.Filter = "Archivo XML (*.xml)|*.xml";
            lyrics.Title = "Selecciona el Archivo donde tienes la letra de la Cancion";
            lyrics.RestoreDirectory = true;//Me ayuda a que al cerrar el directorio actual sea el que
            // se marca en el InitialDirectory y no en la que se quedo
            lyrics.InitialDirectory = @"..\..\..\Lyrics";
            try
            {  
             lyrics.ShowDialog();
             FileInfo informacionLyrics = new FileInfo(lyrics.FileName);
             txtLyrics.Text = informacionLyrics.FullName;
             StreamReader sr = new StreamReader(informacionLyrics.FullName);
             rctLetra.Text=sr.ReadToEnd();
            }
            catch (Exception)
            {
                MessageBox.Show("Es importante seleccionar un archivo XML para asignarselo a la letra de la cancion", "NO Selecciono NINGUN archivo XML", MessageBoxButtons.OK);   
            }
        }
        private void btnCaratula_Click(object sender, EventArgs e)
        {
            OpenFileDialog caratula = new OpenFileDialog();
            caratula.Filter = "Imagen de Mapa de Bits (*.bmp)|*.bmp"+
                "|Graficos Animados (*.gif)|*.gif|" +
                "Imagenes JPG (*.jpg)|*.jpg|All (*.*)|*.* |PNG (*.png)|*.png ";
            caratula.FilterIndex = 3;
            caratula.Title = "Seleccione el Archivo donde esta la Caratula del Disco";            
            caratula.InitialDirectory = @"..\..\..\Caratulas";
            caratula.RestoreDirectory = true;
            try
            {
                caratula.ShowDialog();
                FileInfo informacionCaratula = new FileInfo(caratula.FileName);
                txtCaratula.Text = informacionCaratula.FullName;
                pctCaratula.Image = System.Drawing.Image.FromFile(informacionCaratula.FullName);
                txtDisco.Text = informacionCaratula.Name.Substring(0, informacionCaratula.Name.Length - 4);
            }
            catch (Exception)
            {
               MessageBox.Show("Es importante seleccionar un archivo de imagen para asignarselo a la caratula del disco", "NO Selecciono NINGUN archivo de Imagen", MessageBoxButtons.OK);   
            }
            
        }
        private void btnImagenArtista_Click(object sender, EventArgs e)
        {
            OpenFileDialog artista = new OpenFileDialog();
            artista.Filter = "Imagen de Mapa de Bits (*.bmp)|*.bmp" +
                "|Graficos Animados (*.gif)|*.gif|" +
                "Imagenes JPG (*.jpg)|*.jpg|Todos los Archivos(*.*)|*.* |PNG (*.png)|*.png ";
            artista.FilterIndex = 3;
            artista.RestoreDirectory = true;
            artista.InitialDirectory = @"..\..\..\Artistas";
            try
            {
                artista.ShowDialog();
                FileInfo informacionArtista = new FileInfo(artista.FileName);
                txtImagenArtista.Text = informacionArtista.FullName;
                pctArtista.Image = System.Drawing.Image.FromFile(informacionArtista.FullName);
                txtArtista.Text = informacionArtista.Name.Substring(0, informacionArtista.Name.Length - 4);
            }
            catch (Exception)
            {
                MessageBox.Show("Es importante seleccionar un archivo de imagen para asignarselo a la foto del Artista", "NO Selecciono NINGUN archivo de Imagen", MessageBoxButtons.OK);   
            } 
        }
        private void btnBiografia_Click(object sender, EventArgs e)
        {
            OpenFileDialog biografia = new OpenFileDialog();
            biografia.Filter = "Archivos de Texto (*.txt)|*.txt" +
                "|Archivos de Word (*.doc)|*.doc"; 
            biografia.FilterIndex = 1;
            biografia.RestoreDirectory = true;
            biografia.InitialDirectory = @"..\..\..\Biografias";
            try
            {
                biografia.ShowDialog();
                FileInfo informacionBiografia = new FileInfo(biografia.FileName);
                txtBiografia.Text = informacionBiografia.FullName;
                StreamReader sr = new StreamReader(informacionBiografia.FullName);
                rctBiografia.Text = sr.ReadToEnd();
            }
            catch (Exception)
            {
                MessageBox.Show("Es importante seleccionar un archivo de texto para asignarselo a la Biografia del Artista", "NO Selecciono NINGUN archivo de TEXTO", MessageBoxButtons.OK);                  
            }            
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cancion nuevaCancion = new Cancion();
                        
            listaNuevaDeCanciones = new List<Cancion>();
            listaNuevaDeCanciones = listaDeCanciones;
            listaNuevaDeCanciones.Capacity = listaNuevaDeCanciones.Count + 1;
            listaNuevaDeCanciones.Add(nuevaCancion);

            //Agregar dato por dato
            listaNuevaDeCanciones[listaNuevaDeCanciones.Count - 1].Album = txtDisco.Text;
            listaNuevaDeCanciones[listaNuevaDeCanciones.Count - 1].Artista=txtArtista.Text;
            listaNuevaDeCanciones[listaNuevaDeCanciones.Count - 1].Genero=cboGeneros.Text;
            listaNuevaDeCanciones[listaNuevaDeCanciones.Count - 1].Nombre=txtCancion.Text;
            listaNuevaDeCanciones[listaNuevaDeCanciones.Count - 1].Ruta_Artista=txtImagenArtista.Text;
            listaNuevaDeCanciones[listaNuevaDeCanciones.Count - 1].Ruta_Disco = txtCaratula.Text;
            listaNuevaDeCanciones[listaNuevaDeCanciones.Count - 1].Ruta_Letra = txtLyrics.Text;
            listaNuevaDeCanciones[listaNuevaDeCanciones.Count - 1].Ruta_Cancion = txtUbicacion.Text;
            listaNuevaDeCanciones[listaNuevaDeCanciones.Count - 1].Ruta_Biografia = txtBiografia.Text;

            //Actualizar Cuadricula
            dgvCanciones.DataSource = null;
            dgvCanciones.DataSource = listaNuevaDeCanciones;
                /*Canciones.Cargar(ruta);*/
        }       
        private void btnAgregarOtra_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirArchivo = new OpenFileDialog();
            abrirArchivo.InitialDirectory = @"..\..\..\Canciones\";
            abrirArchivo.RestoreDirectory=true;
            abrirArchivo.ShowDialog();
            LimpiarTodo();
            FileInfo informacion = new FileInfo(abrirArchivo.FileName);
            txtUbicacion.Text = informacion.FullName;
            txtCancion.Text = informacion.Name.Substring(0, informacion.Name.Length - 4);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Guardar todo            
            Canciones nuevasCanciones = new Canciones();
            SaveFileDialog guardarLista = new SaveFileDialog();
            guardarLista.Filter = "Archivos XML (*.xml)|*.xml";
            guardarLista.FilterIndex = 1;
            guardarLista.InitialDirectory = @"..\..\..\Listas";
            guardarLista.RestoreDirectory = true;
            guardarLista.ShowDialog();
            string ruta = guardarLista.FileName;
            nuevasCanciones.Guardar(ruta, listaNuevaDeCanciones);
            Form1.ListaDeCanciones = listaNuevaDeCanciones;
            Form1.banderaActualizar = true;
            this.Close();
        }        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Form1.ListaDeCanciones = listaNuevaDeCanciones;
            Form1.banderaActualizar = true;
            this.Close();
        }
        private void btnObtenerEtiquetas_Click(object sender, EventArgs e)
        {
            SacarEtiquetasMp3(cancionRaza.FullName);
        }
#endregion

        private void tmEscuchar_Tick(object sender, EventArgs e)
        {
            //Asignar al text
            txtDuracion.Text = axWmpReproductor.currentMedia.durationString;
            if (txtDuracion.Text!="00:00")
            {
                tmEscuchar.Stop();
            }
        }

 
       









    }
}