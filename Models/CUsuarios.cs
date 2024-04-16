using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Drawing;

namespace Xeon.Models
{
    public class CUsuarios
    {
        //Fields
        private int _IDUsuario;
        private int _IDPerfil;
        private string _apellidoPaterno;
        private string _apellidoMaterno;
        private string _Nombre;
        private string _Apodo;
        private string _correoElectronico;
        private string _Contraseña;
        private string _Nacimiento;
        private string _fechaRegistro;
        private int _Estado;
        //Properties - Validations
        [DisplayName("Usuario ID")]
        public int IDUsuario
        {
            get { return _IDUsuario; }
            set { _IDUsuario = value; }
        }
        
        [DisplayName("Perfil ID")]
        public int IDPerfil
        {
            get { return _IDPerfil; }
            set { _IDPerfil = value; }
        }

        [DisplayName("Apellido Paterno")]
        [Required(ErrorMessage = "Apellido paterno requerido.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El apellido paterno debe tener entre 3 y 30 caracteres")]
        public string apellidoPaterno
        {
            get { return _apellidoPaterno; }
            set { _apellidoPaterno = value; }
        }

        [DisplayName("Apellido Materno")]
        [Required(ErrorMessage = "Apellido materno requerido.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El apellido materno debe tener entre 3 y 30 caracteres")]
        public string apellidoMaterno
        {
            get { return _apellidoMaterno; }
            set { _apellidoMaterno = value; }
        }

        [DisplayName("Nombre")]
        [Required(ErrorMessage = "Nombre requerido.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 30 caracteres")]
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        [DisplayName("Apodo")]
        [Required(ErrorMessage = "Apodo requerido.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El apodo debe tener entre 3 y 30 caracteres")]
        public string Apodo
        {
            get { return _Apodo; }
            set { _Apodo = value; }
        }

        [DisplayName("Correo electrónico")]
        [Required(ErrorMessage = "Correo electrónico requerido.")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "El correo electrónico debe tener entre 3 y 60 caracteres")]
        public string correoElectronico
        {
            get { return _correoElectronico; }
            set { _correoElectronico = value; }
        }

        [DisplayName("Contraseña")]
        [Required(ErrorMessage = "Contraseña requerida.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "La contraseña debe tener entre 3 y 30 caracteres")]
        public string Contraseña
        {
            get { return _Contraseña; }
            set { _Contraseña = value; }
        }

        [DisplayName("Nacimiento")]
        public string Nacimiento
        {
            get { return _Nacimiento; }
            set { _Nacimiento = value; }
        }

        [DisplayName("Fecha Registro")]
        public string fechaRegistro
        {
            get { return _fechaRegistro; }
            set { _fechaRegistro = value; }
        }

        [DisplayName("Estado")]
        public int Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }
    }

    public class CUsuariosB
    {
        //Fields
        private int _IDUsuario;
        private int _IDPerfil;
        private string _apellidoPaterno;
        private string _apellidoMaterno;
        private string _Nombre;
        private string _Apodo;
        private string _correoElectronico;
        private string _Contraseña;
        private string _Nacimiento;
        private string _fechaRegistro;
        private int _Estado;
        //Properties - Validations
        [DisplayName("Usuario ID")]
        public int IDUsuario
        {
            get { return _IDUsuario; }
            set { _IDUsuario = value; }
        }

        [DisplayName("Perfil ID")]
        public int IDPerfil
        {
            get { return _IDPerfil; }
            set { _IDPerfil = value; }
        }

        [DisplayName("Apellido Paterno")]
        [Required(ErrorMessage = "Apellido paterno requerido.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El apellido paterno debe tener entre 3 y 30 caracteres")]
        public string apellidoPaterno
        {
            get { return _apellidoPaterno; }
            set { _apellidoPaterno = value; }
        }

        [DisplayName("Apellido Materno")]
        [Required(ErrorMessage = "Apellido materno requerido.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El apellido materno debe tener entre 3 y 30 caracteres")]
        public string apellidoMaterno
        {
            get { return _apellidoMaterno; }
            set { _apellidoMaterno = value; }
        }

        [DisplayName("Nombre")]
        [Required(ErrorMessage = "Nombre requerido.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 30 caracteres")]
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        [DisplayName("Apodo")]
        [Required(ErrorMessage = "Apodo requerido.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El apodo debe tener entre 3 y 30 caracteres")]
        public string Apodo
        {
            get { return _Apodo; }
            set { _Apodo = value; }
        }

        [DisplayName("Correo electrónico")]
        [Required(ErrorMessage = "Correo electrónico requerido.")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "El correo electrónico debe tener entre 3 y 60 caracteres")]
        public string correoElectronico
        {
            get { return _correoElectronico; }
            set { _correoElectronico = value; }
        }

        [DisplayName("Contraseña")]
        [Required(ErrorMessage = "Contraseña requerida.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "La contraseña debe tener entre 3 y 30 caracteres")]
        public string Contraseña
        {
            get { return _Contraseña; }
            set { _Contraseña = value; }
        }

        [DisplayName("Nacimiento")]
        public string Nacimiento
        {
            get { return _Nacimiento; }
            set { _Nacimiento = value; }
        }

        [DisplayName("Fecha Registro")]
        public string fechaRegistro
        {
            get { return _fechaRegistro; }
            set { _fechaRegistro = value; }
        }

        [DisplayName("Estado")]
        public int Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }
    }

    public class CListasB
    {
        //Fields
        private int _IDLista;
        private int _IDUsuario;
        private string _Titulo;
        private string _Descripcion;
        private string _fechaRegistro;
        private int _Estado;
        //Properties - Validations
        [DisplayName("Usuario ID")]
        public int IDUsuario
        {
            get { return _IDUsuario; }
            set { _IDUsuario = value; }
        }

        [DisplayName("Lista ID")]
        public int IDLista
        {
            get { return _IDLista; }
            set { _IDLista = value; }
        }

        [DisplayName("Título")]
        [Required(ErrorMessage = "Título requerido.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El título debe tener entre 3 y 30 caracteres")]
        public string Titulo
        {
            get { return _Titulo; }
            set { _Titulo = value; }
        }

        [DisplayName("Descripción")]
        [Required(ErrorMessage = "Descripción requerida.")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "La descripción debe tener entre 3 y 60 caracteres")]
        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        [DisplayName("Fecha Registro")]
        public string fechaRegistro
        {
            get { return _fechaRegistro; }
            set { _fechaRegistro = value; }
        }

        [DisplayName("Estado")]
        public int Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }
    }

    public class CPerfiles
    {
        //Fields
        private int _IDPerfil;
        private string _Nombre;
        private string _Descripcion;
        private int _Estado;
        //Properties - Validations

        [DisplayName("Perfil ID")]
        public int IDPerfil
        {
            get { return _IDPerfil; }
            set { _IDPerfil = value; }
        }

        [DisplayName("Nombre")]
        [Required(ErrorMessage = "Nombre requerido.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 30 caracteres")]
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        [DisplayName("Descripción")]
        [Required(ErrorMessage = "Descripción requerida.")]
        [StringLength(90, MinimumLength = 3, ErrorMessage = "La descripción debe tener entre 3 y 30 caracteres")]
        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }
        [DisplayName("Estado")]
        public int Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }
    }

    public class CGeneros
    {
        //Fields
        private int _IDGenero;
        private string _Nombre;
        private string _Descripcion;
        private int _Estado;
        //Properties - Validations

        [DisplayName("Genero ID")]
        public int IDGenero
        {
            get { return _IDGenero; }
            set { _IDGenero = value; }
        }

        [DisplayName("Nombre")]
        [Required(ErrorMessage = "Nombre requerido.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 30 caracteres")]
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        [DisplayName("Descripción")]
        [Required(ErrorMessage = "Descripción requerida.")]
        [StringLength(90, MinimumLength = 3, ErrorMessage = "La descripción debe tener entre 3 y 30 caracteres")]
        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }
        [DisplayName("Estado")]
        public int Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }
    }
    public class CArtistas
    {
        //Fields
        private int _IDArtista;
        private string _apellidoPaterno;
        private string _apellidoMaterno;
        private string _Nombre;
        private string _Apodo;
        private string _Nacimiento;
        private string _Nacionalidad;
        private byte[] _Imagen;
        private int _Estado;

        //Properties - Validations

        [DisplayName("Artista ID")]
        public int IDArtista
        {
            get { return _IDArtista; }
            set { _IDArtista = value; }
        }

        [DisplayName("Apellido Paterno")]
        [Required(ErrorMessage = "Apellido paterno requerido.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El apellido paterno debe tener entre 3 y 30 caracteres")]
        public string apellidoPaterno
        {
            get { return _apellidoPaterno; }
            set { _apellidoPaterno = value; }
        }

        [DisplayName("Apellido Materno")]
        [Required(ErrorMessage = "Apellido materno requerido.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El apellido materno debe tener entre 3 y 30 caracteres")]
        public string apellidoMaterno
        {
            get { return _apellidoMaterno; }
            set { _apellidoMaterno = value; }
        }

        [DisplayName("Nombre")]
        [Required(ErrorMessage = "Nombre requerido.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 30 caracteres")]
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        [DisplayName("Apodo")]
        [Required(ErrorMessage = "Apodo requerido.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El apodo debe tener entre 3 y 30 caracteres")]
        public string Apodo
        {
            get { return _Apodo; }
            set { _Apodo = value; }
        }
        [DisplayName("Nacimiento")]
        public string Nacimiento
        {
            get { return _Nacimiento; }
            set { _Nacimiento = value; }
        }
        [DisplayName("Nacionalidad")]
        [Required(ErrorMessage = "Nacionalidad requerida.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "La nacionalidad debe tener entre 3 y 30 caracteres")]
        public string Nacionalidad
        {
            get { return _Nacionalidad; }
            set { _Nacionalidad = value; }
        }
        [DisplayName("Imagen")]
        public byte[] Imagen
        {
            get { return _Imagen; }
            set { _Imagen = value; }
        }
        [DisplayName("Estado")]
        public int Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }
    }
    public class CArtistaGenero
    {
        //Fields
        private int _IDArtistaGenero;
        private int _IDArtista;
        private int _IDGenero;
        //Properties - Validations

        [DisplayName("ArtistaGenero ID")]
        public int IDArtistaGenero
        {
            get { return _IDArtistaGenero; }
            set { _IDArtistaGenero = value; }
        }

        [DisplayName("Artista ID")]
        public int IDArtista
        {
            get { return _IDArtista; }
            set { _IDArtista = value; }
        }

        [DisplayName("Género ID")]
        public int IDGenero
        {
            get { return _IDGenero; }
            set { _IDGenero = value; }
        }
    }

    public class CAlbumes
    {
        //Fields
        private int _IDAlbum;
        private string _Titulo;
        private string _fechaLanzamiento;
        private byte[] _Imagen;
        private int _Estado;

        //Properties - Validations

        [DisplayName("Album ID")]
        public int IDAlbum
        {
            get { return _IDAlbum; }
            set { _IDAlbum = value; }
        }

        [DisplayName("Titulo")]
        [Required(ErrorMessage = "Título requerido.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El título debe tener entre 3 y 30 caracteres")]
        public string Titulo
        {
            get { return _Titulo; }
            set { _Titulo = value; }
        }

        [DisplayName("Fecha Lanzamiento")]
        public string fechaLanzamiento
        {
            get { return _fechaLanzamiento; }
            set { _fechaLanzamiento = value; }
        }

        [DisplayName("Imagen")]
        public byte[] Imagen
        {
            get { return _Imagen; }
            set { _Imagen = value; }
        }

        [DisplayName("Estado")]
        public int Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }
    }

    public class CAlbumArtista
    {
        //Fields
        private int _IDAlbumArtista;
        private int _IDArtista;
        private int _IDAlbum;
        //Properties - Validations

        [DisplayName("AlbumArtista ID")]
        public int IDAlbumArtista
        {
            get { return _IDAlbumArtista; }
            set { _IDAlbumArtista = value; }
        }

        [DisplayName("Artista ID")]
        public int IDArtista
        {
            get { return _IDArtista; }
            set { _IDArtista = value; }
        }

        [DisplayName("Album ID")]
        public int IDAlbum
        {
            get { return _IDAlbum; }
            set { _IDAlbum = value; }
        }
    }

    public class CAlbumGenero
    {
        //Fields
        private int _IDAlbumGenero;
        private int _IDGenero;
        private int _IDAlbum;
        //Properties - Validations

        [DisplayName("AlbumGenero ID")]
        public int IDAlbumGenero
        {
            get { return _IDAlbumGenero; }
            set { _IDAlbumGenero = value; }
        }

        [DisplayName("Genero ID")]
        public int IDGenero
        {
            get { return _IDGenero; }
            set { _IDGenero = value; }
        }

        [DisplayName("Album ID")]
        public int IDAlbum
        {
            get { return _IDAlbum; }
            set { _IDAlbum = value; }
        }
    }
    public class CCancionGenero
    {
        //Fields
        private int _IDCancionGenero;
        private int _IDGenero;
        private int _IDCancion;
        //Properties - Validations

        [DisplayName("CancionGenero ID")]
        public int IDCancionGenero
        {
            get { return _IDCancionGenero; }
            set { _IDCancionGenero = value; }
        }

        [DisplayName("Genero ID")]
        public int IDGenero
        {
            get { return _IDGenero; }
            set { _IDGenero = value; }
        }

        [DisplayName("Cancion ID")]
        public int IDCancion
        {
            get { return _IDCancion; }
            set { _IDCancion = value; }
        }
    }
    public class CCanciones
    {
        //Fields
        private int _IDCancion;
        private int _IDAlbum;
        private string _Titulo;
        private int _Duracion;
        private string _Ruta;
        private int _Estado;
        //Properties - Validations
        [DisplayName("Canción ID")]
        public int IDCancion
        {
            get { return _IDCancion; }
            set { _IDCancion = value; }
        }

        [DisplayName("Álbum ID")]
        public int IDAlbum
        {
            get { return _IDAlbum; }
            set { _IDAlbum = value; }
        }

        [DisplayName("Título")]
        [Required(ErrorMessage = "Título requerido.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El título debe tener entre 3 y 30 caracteres")]
        public string Titulo
        {
            get { return _Titulo; }
            set { _Titulo = value; }
        }
        [DisplayName("Duración")]
        public int Duracion
        {
            get { return _Duracion; }
            set { _Duracion = value; }
        }

        [DisplayName("Ruta")]
        [Required(ErrorMessage = "Ruta requerida.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "La ruta debe tener entre 3 y 30 caracteres")]
        public string Ruta
        {
            get { return _Ruta; }
            set { _Ruta = value; }
        }

        [DisplayName("Estado")]
        public int Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }
    }
    public class CListaCancion
    {
        //Fields
        private int _IDListaCancion;
        private int _IDLista;
        private int _IDCancion;
        //Properties - Validations

        [DisplayName("Lista ID")]
        public int IDListaCancion
        {
            get { return _IDListaCancion; }
            set { _IDListaCancion = value; }
        }

        [DisplayName("Canción ID")]
        public int IDLista
        {
            get { return _IDLista; }
            set { _IDLista = value; }
        }

        [DisplayName("Orden")]
        public int IDCancion
        {
            get { return _IDCancion; }
            set { _IDCancion = value; }
        }
    }

    public class CAlbumCancion
    {
        //Fields
        private int _IDAlbumCancion;
        private int _IDAlbum;
        private int _IDCancion;
        //Properties - Validations

        [DisplayName("Álbum ID")]
        public int IDAlbumCancion
        {
            get { return _IDAlbumCancion; }
            set { _IDAlbumCancion = value; }
        }

        [DisplayName("Canción ID")]
        public int IDAlbum
        {
            get { return _IDAlbum; }
            set { _IDAlbum = value; }
        }

        [DisplayName("Orden")]
        public int IDCancion
        {
            get { return _IDCancion; }
            set { _IDCancion = value; }
        }
    }

    public class CListas
    {
        //Fields
        private int _IDLista;
        private int _IDUsuario;
        private string _Titulo;
        private string _Descripcion;
        private string _fechaRegistro;
        private int _Estado;
        //Properties - Validations
        [DisplayName("Lista ID")]
        public int IDLista
        {
            get { return _IDLista; }
            set { _IDLista = value; }
        }
        [DisplayName("Usuario ID")]
        public int IDUsuario
        {
            get { return _IDUsuario; }
            set { _IDUsuario = value; }
        }

        [DisplayName("Titulo")]
        [Required(ErrorMessage = "Título requerido.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El título debe tener entre 3 y 30 caracteres")]
        public string Titulo
        {
            get { return _Titulo; }
            set { _Titulo = value; }
        }

        [DisplayName("Descripción")]
        [Required(ErrorMessage = "Descripción requerida.")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "La descripción debe tener entre 3 y 60 caracteres")]
        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        [DisplayName("Fecha Registro")]
        public string fechaRegistro
        {
            get { return _fechaRegistro; }
            set { _fechaRegistro = value; }
        }

        [DisplayName("Estado")]
        public int Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }
    }
}
