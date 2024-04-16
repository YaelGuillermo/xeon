using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Xeon.Models;
using Xeon.Views;
using System.Drawing;
using System.Windows.Forms;

namespace Xeon.Repositories
{
    public class UserRepository : BaseRepository, IUsuarios
    {
        // Constructor
        public UserRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Methods
        public void Add(CUsuarios usuariosModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "InsertarUsuarios";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@IDPerfil", SqlDbType.Int).Value = usuariosModel.IDPerfil;
                command.Parameters.Add("@apellidoPaterno", SqlDbType.NVarChar).Value = usuariosModel.apellidoPaterno;
                command.Parameters.Add("@apellidoMaterno", SqlDbType.NVarChar).Value = usuariosModel.apellidoMaterno;
                command.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = usuariosModel.Nombre;
                command.Parameters.Add("@Apodo", SqlDbType.NVarChar).Value = usuariosModel.Apodo;
                command.Parameters.Add("@correoElectronico", SqlDbType.NVarChar).Value = usuariosModel.correoElectronico;
                command.Parameters.Add("@Contraseña", SqlDbType.NVarChar).Value = usuariosModel.Contraseña;
                command.Parameters.Add("@Nacimiento", SqlDbType.Date).Value = usuariosModel.Nacimiento;
                command.Parameters.Add("@Estado", SqlDbType.Int).Value = usuariosModel.Estado;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "EliminarUsuarios";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Edit(CUsuarios usuariosModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "ActualizarUsuarios";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@IDPerfil", SqlDbType.Int).Value = usuariosModel.IDPerfil;
                command.Parameters.Add("@apellidoPaterno", SqlDbType.NVarChar).Value = usuariosModel.apellidoPaterno;
                command.Parameters.Add("@apellidoMaterno", SqlDbType.NVarChar).Value = usuariosModel.apellidoMaterno;
                command.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = usuariosModel.Nombre;
                command.Parameters.Add("@Apodo", SqlDbType.NVarChar).Value = usuariosModel.Apodo;
                command.Parameters.Add("@correoElectronico", SqlDbType.NVarChar).Value = usuariosModel.correoElectronico;
                command.Parameters.Add("@Contraseña", SqlDbType.NVarChar).Value = usuariosModel.Contraseña;
                command.Parameters.Add("@Nacimiento", SqlDbType.Date).Value = usuariosModel.Nacimiento;
                command.Parameters.Add("@Estado", SqlDbType.Bit).Value = usuariosModel.Estado;
                command.Parameters.Add("@IDUsuario", SqlDbType.Int).Value = usuariosModel.IDUsuario;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IEnumerable<CUsuarios> GetAll()
        {
            var userList = new List<CUsuarios>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from Usuarios order by IDUsuario asc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new CUsuarios();
                        userModel.IDUsuario = (int)reader[0];
                        userModel.IDPerfil = (int)reader[1];
                        userModel.apellidoPaterno = reader[2].ToString();
                        userModel.apellidoMaterno = reader[3].ToString();
                        userModel.Nombre = reader[4].ToString();
                        userModel.Apodo = reader[5].ToString();
                        userModel.correoElectronico = reader[6].ToString();
                        userModel.Contraseña = reader[7].ToString();
                        userModel.Nacimiento = reader[8].ToString();
                        userModel.fechaRegistro = reader[9].ToString();
                        userModel.Estado = (byte)(reader[10] as bool? == true ? 1 : 0);
                        userList.Add(userModel);
                    }
                }
                connection.Close();
            }
            return userList;
        }

        public IEnumerable<CUsuarios> GetByValue(string value)
        {
            var userList = new List<CUsuarios>();
            int ID = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string userName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select * from Usuarios 
                                        where IDUsuario = @IDUsuario or Nombre like @Nombre+'%'
                                        order by IDUsuario asc";
                command.Parameters.Add("@IDUsuario", SqlDbType.Int).Value = ID;
                command.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = userName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new CUsuarios();
                        userModel.IDUsuario = (int)reader[0];
                        userModel.IDPerfil = (int)reader[1];
                        userModel.apellidoPaterno = reader[2].ToString();
                        userModel.apellidoMaterno = reader[3].ToString();
                        userModel.Nombre = reader[4].ToString();
                        userModel.Apodo = reader[5].ToString();
                        userModel.correoElectronico = reader[6].ToString();
                        userModel.Contraseña = reader[7].ToString();
                        userModel.Nacimiento = reader[8].ToString();
                        userModel.fechaRegistro = reader[9].ToString();
                        userModel.Estado = (byte)(reader[10] as bool? == true ? 1 : 0);
                        userList.Add(userModel);
                    }
                }
                connection.Close();
            }
            return userList;
        }

        public List<int> GetAllIDs()
        {
            var foraignList = new List<int>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select IDPerfil from Perfiles order by IDPerfil asc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new CPerfiles();
                        userModel.IDPerfil = (int)reader[0];
                        foraignList.Add(userModel.IDPerfil);
                    }
                }
                connection.Close();
            }
            return foraignList;
        }
    }
    public class UserBRepository : BaseRepository, IUsuariosB
    {
        // Constructor
        public UserBRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Methods
        public void Add(CUsuariosB usuariosModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "InsertarUsuarios";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@IDPerfil", SqlDbType.Int).Value = 1;
                command.Parameters.Add("@apellidoPaterno", SqlDbType.NVarChar).Value = usuariosModel.apellidoPaterno;
                command.Parameters.Add("@apellidoMaterno", SqlDbType.NVarChar).Value = usuariosModel.apellidoMaterno;
                command.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = usuariosModel.Nombre;
                command.Parameters.Add("@Apodo", SqlDbType.NVarChar).Value = usuariosModel.Apodo;
                command.Parameters.Add("@correoElectronico", SqlDbType.NVarChar).Value = usuariosModel.correoElectronico;
                command.Parameters.Add("@Contraseña", SqlDbType.NVarChar).Value = usuariosModel.Contraseña;
                command.Parameters.Add("@Nacimiento", SqlDbType.Date).Value = usuariosModel.Nacimiento;
                command.Parameters.Add("@Estado", SqlDbType.Int).Value = 1;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }

    public class ListasBRepository : BaseRepository, IListasB
    {
        // Constructor
        public ListasBRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Methods
        public void Add(CListasB usuariosModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "InsertarLista";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@IDUsuario", SqlDbType.Int).Value = GlobalVariables.IDUsuario;
                command.Parameters.Add("@Titulo", SqlDbType.NVarChar).Value = usuariosModel.Titulo;
                command.Parameters.Add("@Descripcion", SqlDbType.NVarChar).Value = usuariosModel.Descripcion;
                command.Parameters.Add("@Estado", SqlDbType.Int).Value = usuariosModel.Estado;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "EliminarLista";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@IDLista", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Edit(CListasB usuariosModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                //command.CommandText = @"Update Usuarios 
                //                        set IDPerfil = @IDPerfil, apellidoPaterno = @apellidoPaterno, apellidoMaterno = @apellidoMaterno, Nombre = @Nombre, correoElectronico = @correoElectronico, Contraseña = @Contraseña
                //                        where IDUsuario = @IDUsuario";
                command.CommandText = "ActualizarLista";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@IDUsuario", SqlDbType.Int).Value = GlobalVariables.IDUsuario;
                command.Parameters.Add("@Titulo", SqlDbType.NVarChar).Value = usuariosModel;
                command.Parameters.Add("@Descripcion", SqlDbType.NVarChar).Value = usuariosModel.Descripcion;
                command.Parameters.Add("@Estado", SqlDbType.Int).Value = 1;
                command.Parameters.Add("@IDLista", SqlDbType.Int).Value = usuariosModel.IDLista;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IEnumerable<CListasB> GetAll()
        {
            var userList = new List<CListasB>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from Listas order by IDLista asc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new CListasB();
                        userModel.IDLista = (int)reader[0];
                        userModel.IDUsuario = (int)reader[1];
                        userModel.Titulo = reader[2].ToString();
                        userModel.Descripcion = reader[3].ToString();
                        userModel.fechaRegistro = reader[4].ToString();
                        userModel.Estado = (byte)(reader[5] as bool? == true ? 1 : 0);
                        userList.Add(userModel);
                    }
                }
                connection.Close();
            }
            return userList;
        }

        /*public IEnumerable<CUsuarios> GetByValue(string value)
        {
            var userList = new List<CUsuarios>();
            int ID = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string userName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select * from Usuarios 
                                        where IDUsuario = @IDUsuario or Nombre like @Nombre+'%'
                                        order by IDUsuario asc";
                command.Parameters.Add("@IDUsuario", SqlDbType.Int).Value = ID;
                command.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = userName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new CUsuarios();
                        userModel.IDUsuario = (int)reader[0];
                        userModel.IDPerfil = (int)reader[1];
                        userModel.apellidoPaterno = reader[2].ToString();
                        userModel.apellidoMaterno = reader[3].ToString();
                        userModel.Nombre = reader[4].ToString();
                        userModel.Apodo = reader[5].ToString();
                        userModel.correoElectronico = reader[6].ToString();
                        userModel.Contraseña = reader[7].ToString();
                        userModel.Nacimiento = reader[8].ToString();
                        userModel.fechaRegistro = reader[9].ToString();
                        userModel.Estado = (byte)(reader[10] as bool? == true ? 1 : 0);
                        userList.Add(userModel);
                    }
                }
                connection.Close();
            }
            return userList;
        }*/

        public List<CListasB> GetLists()
        {
            var foraignList = new List<CListasB>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT IDLista, Titulo FROM Listas WHERE IDUsuario = " + GlobalVariables.IDUsuario + " ORDER BY IDLista ASC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new CListasB();
                        userModel.IDLista = (int)reader["IDLista"];
                        userModel.Titulo = (string)reader["Titulo"];
                        foraignList.Add(userModel);
                    }
                }
                connection.Close();
            }
            return foraignList;
        }

    }

    public class ReproducirRepository : BaseRepository, IReproducir
    {
        // Constructor
        public ReproducirRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<CListasB> GetLists()
        {
            var foraignList = new List<CListasB>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT IDLista, Titulo FROM Listas WHERE IDUsuario = " + GlobalVariables.IDUsuario + " ORDER BY IDLista ASC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new CListasB();
                        userModel.IDLista = (int)reader["IDLista"];
                        userModel.Titulo = (string)reader["Titulo"];
                        foraignList.Add(userModel);
                    }
                }
                connection.Close();
            }
            return foraignList;
        }

    }

    public class ProfileRepository : BaseRepository, IPerfiles
    {
        // Constructor
        public ProfileRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Methods
        public void Add(CPerfiles perfilesModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "InsertarPerfiles";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = perfilesModel.Nombre;
                command.Parameters.Add("@Descripcion", SqlDbType.NVarChar).Value = perfilesModel.Descripcion;
                command.Parameters.Add("@Estado", SqlDbType.Bit).Value = perfilesModel.Estado;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "EliminarPerfiles";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@IDPerfil", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Edit(CPerfiles usuariosModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"ActualizarPerfiles";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = usuariosModel.Nombre;
                command.Parameters.Add("@Descripcion", SqlDbType.NVarChar).Value = usuariosModel.Descripcion;
                command.Parameters.Add("@Estado", SqlDbType.Bit).Value = usuariosModel.Estado;
                command.Parameters.Add("@IDPerfil", SqlDbType.Int).Value = usuariosModel.IDPerfil;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IEnumerable<CPerfiles> GetAll()
        {
            var userList = new List<CPerfiles>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from Perfiles order by IDPerfil asc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new CPerfiles();
                        userModel.IDPerfil = (int)reader[0];
                        userModel.Nombre = reader[1].ToString();
                        userModel.Descripcion = reader[2].ToString();
                        userModel.Estado = (byte)(reader[3] as bool? == true ? 1 : 0);
                        userList.Add(userModel);
                    }
                }
                connection.Close();
            }
            return userList;
        }

        public IEnumerable<CPerfiles> GetByValue(string value)
        {
            var userList = new List<CPerfiles>();
            int ID = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string userName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select * from Perfiles 
                                        where IDPerfil = @IDPerfil or Nombre like @Nombre+'%'
                                        order by IDPerfil asc";
                command.Parameters.Add("@IDPerfil", SqlDbType.Int).Value = ID;
                command.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = userName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new CPerfiles();
                        userModel.IDPerfil = (int)reader[0];
                        userModel.Nombre = reader[1].ToString();
                        userModel.Descripcion = reader[2].ToString();
                        userModel.Estado = (byte)(reader[3] as bool? == true ? 1 : 0);
                        userList.Add(userModel);
                    }
                }
                connection.Close();
            }
            return userList;
        }
    }

    public class GenreRepository : BaseRepository, IGeneros
    {
        // Constructor
        public GenreRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Methods
        public void Add(CGeneros GenerosModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "InsertarGenero";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = GenerosModel.Nombre;
                command.Parameters.Add("@Descripcion", SqlDbType.NVarChar).Value = GenerosModel.Descripcion;
                command.Parameters.Add("@Estado", SqlDbType.Bit).Value = GenerosModel.Estado;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "EliminarGenero";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@IDGenero", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Edit(CGeneros Model)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "ActualizarGenero";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = Model.Nombre;
                command.Parameters.Add("@Descripcion", SqlDbType.NVarChar).Value = Model.Descripcion;
                command.Parameters.Add("@Estado", SqlDbType.Bit).Value = Model.Estado;
                command.Parameters.Add("@IDGenero", SqlDbType.Int).Value = Model.IDGenero;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IEnumerable<CGeneros> GetAll()
        {
            var tableList = new List<CGeneros>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from Generos order by IDGenero asc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new CGeneros();
                        userModel.IDGenero = (int)reader[0];
                        userModel.Nombre = reader[1].ToString();
                        userModel.Descripcion = reader[2].ToString();
                        userModel.Estado = (byte)(reader[3] as bool? == true ? 1 : 0);
                        tableList.Add(userModel);
                    }
                }
                connection.Close();
            }
            return tableList;
        }

        public IEnumerable<CGeneros> GetByValue(string value)
        {
            var tableList = new List<CGeneros>();
            int ID = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string userName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select * from Generos 
                                        where IDGenero = @IDGenero or Nombre like @Nombre+'%'
                                        order by IDGenero asc";
                command.Parameters.Add("@IDGenero", SqlDbType.Int).Value = ID;
                command.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = userName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new CGeneros();
                        userModel.IDGenero = (int)reader[0];
                        userModel.Nombre = reader[1].ToString();
                        userModel.Descripcion = reader[2].ToString();
                        userModel.Estado = (byte)(reader[3] as bool? == true ? 1 : 0);
                        tableList.Add(userModel);
                    }
                }
                connection.Close();
            }
            return tableList;
        }
    }
    public class ArtistRepository : BaseRepository, IArtistas
    {
        // Constructor
        public ArtistRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Methods
        public void Add(CArtistas ArtistasModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "InsertarArtista";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@apellidoPaterno", SqlDbType.NVarChar).Value = ArtistasModel.apellidoPaterno;
                command.Parameters.Add("@apellidoMaterno", SqlDbType.NVarChar).Value = ArtistasModel.apellidoMaterno;
                command.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = ArtistasModel.Nombre;
                command.Parameters.Add("@Apodo", SqlDbType.NVarChar).Value = ArtistasModel.Apodo;
                command.Parameters.Add("@Nacimiento", SqlDbType.Date).Value = ArtistasModel.Nacimiento;
                command.Parameters.Add("@Nacionalidad", SqlDbType.NVarChar).Value = ArtistasModel.Nacionalidad;
                command.Parameters.Add("@Imagen", SqlDbType.Image).Value = ArtistasModel.Imagen;
                command.Parameters.Add("@Estado", SqlDbType.Bit).Value = ArtistasModel.Estado;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "EliminarArtista";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@IDArtista", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Edit(CArtistas ArtistasModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"ActualizarArtista";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@apellidoPaterno", SqlDbType.NVarChar).Value = ArtistasModel.apellidoPaterno;
                command.Parameters.Add("@apellidoMaterno", SqlDbType.NVarChar).Value = ArtistasModel.apellidoMaterno;
                command.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = ArtistasModel.Nombre;
                command.Parameters.Add("@Apodo", SqlDbType.NVarChar).Value = ArtistasModel.Apodo;
                command.Parameters.Add("@Nacimiento", SqlDbType.Date).Value = ArtistasModel.Nacimiento;
                command.Parameters.Add("@Nacionalidad", SqlDbType.NVarChar).Value = ArtistasModel.Nacionalidad;
                command.Parameters.Add("@Imagen", SqlDbType.Image).Value = ArtistasModel.Imagen;
                command.Parameters.Add("@Estado", SqlDbType.Bit).Value = ArtistasModel.Estado;
                command.Parameters.Add("@IDArtista", SqlDbType.Int).Value = ArtistasModel.IDArtista;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IEnumerable<CArtistas> GetAll()
        {
            var tableList = new List<CArtistas>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from Artistas order by IDArtista asc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var tableModel = new CArtistas();
                        tableModel.IDArtista = (int)reader[0];
                        tableModel.apellidoPaterno = reader[1].ToString();
                        tableModel.apellidoMaterno = reader[2].ToString();
                        tableModel.Nombre = reader[3].ToString();
                        tableModel.Apodo = reader[4].ToString();
                        tableModel.Nacimiento = reader[5].ToString();
                        tableModel.Nacionalidad = reader[6].ToString();
                        tableModel.Imagen = (byte[])reader[7];
                        tableModel.Estado = (byte)(reader[8] as bool? == true ? 1 : 0);
                        tableList.Add(tableModel);
                    }
                }
                connection.Close();
            }
            return tableList;
        }

        public IEnumerable<CArtistas> GetByValue(string value)
        {
            var tableList = new List<CArtistas>();
            int ID = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string userName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select * from Artistas
                                        where IDArtista = @IDArtista or Apodo like @Apodo+'%'
                                        order by IDArtista asc";
                command.Parameters.Add("@IDArtista", SqlDbType.Int).Value = ID;
                command.Parameters.Add("@Apodo", SqlDbType.NVarChar).Value = userName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var tableModel = new CArtistas();
                        tableModel.IDArtista = (int)reader[0];
                        tableModel.apellidoPaterno = reader[1].ToString();
                        tableModel.apellidoMaterno = reader[2].ToString();
                        tableModel.Nombre = reader[3].ToString();
                        tableModel.Apodo = reader[4].ToString();
                        tableModel.Nacimiento = reader[5].ToString();
                        tableModel.Nacionalidad = reader[6].ToString();
                        tableModel.Imagen = (byte[])reader[7];
                        tableModel.Estado = (byte)(reader[8] as bool? == true ? 1 : 0);
                        tableList.Add(tableModel);
                    }
                }
                connection.Close();
            }
            return tableList;
        }
    }

    public class ArtistGenreRepository : BaseRepository, IArtistaGenero
    {
        // Constructor
        public ArtistGenreRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Methods
        public void Add(CArtistaGenero ArtistaGeneroModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "InsertarArtistaGenero";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@IDArtista", SqlDbType.Int).Value = ArtistaGeneroModel.IDArtista;
                command.Parameters.Add("@IDGenero", SqlDbType.Int).Value = ArtistaGeneroModel.IDGenero;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "EliminarArtistaGenero";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@IDArtistaGenero", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Edit(CArtistaGenero ArtistaGeneroModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "ActualizarArtistaGenero";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@IDArtista", SqlDbType.Int).Value = ArtistaGeneroModel.IDArtista;
                command.Parameters.Add("@IDGenero", SqlDbType.Int).Value = ArtistaGeneroModel.IDGenero;
                command.Parameters.Add("@IDArtistaGenero", SqlDbType.Int).Value = ArtistaGeneroModel.IDArtistaGenero;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IEnumerable<CArtistaGenero> GetAll()
        {
            var tableList = new List<CArtistaGenero>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from ArtistaGenero order by IDArtistaGenero asc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var tableModel = new CArtistaGenero();
                        tableModel.IDArtistaGenero = (int)reader[0];
                        tableModel.IDArtista = (int)reader[1];
                        tableModel.IDGenero = (int)reader[2];
                        tableList.Add(tableModel);
                    }
                }
                connection.Close();
            }
            return tableList;
        }

        public (List<int>, List<int>) GetAllIDs()
        {
            var foraignArtist = new List<int>();
            var foraignGenre = new List<int>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select IDArtista from Artistas order by IDArtista asc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new CArtistas();
                        userModel.IDArtista = (int)reader[0];
                        foraignArtist.Add(userModel.IDArtista);
                    }
                }
                connection.Close();
                connection.Open();
                command.CommandText = "Select IDGenero from Generos order by IDGenero asc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new CGeneros();
                        userModel.IDGenero = (int)reader[0];
                        foraignGenre.Add(userModel.IDGenero);
                    }
                }
                connection.Close();
            }
            return (foraignArtist, foraignGenre);
        }


        public IEnumerable<CArtistaGenero> GetByValue(string value)
        {
            var tableList = new List<CArtistaGenero>();
            int ID = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select * from ArtistaGenero 
                                        where IDArtistaGenero = @IDArtistaGenero'
                                        order by IDArtistaGenero asc";
                //command.Parameters.Add("@IDArtista", SqlDbType.Int).Value = ID;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var tableModel = new CArtistaGenero();
                        tableModel.IDArtistaGenero = (int)reader[0];
                        tableModel.IDArtista = (int)reader[1];
                        tableModel.IDGenero = (int)reader[2];
                        tableList.Add(tableModel);
                    }
                }
                connection.Close();
            }
            return tableList;
        }
    }

    public class AlbumArtistRepository : BaseRepository, IAlbumArtista
    {
        // Constructor
        public AlbumArtistRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Methods
        public void Add(CAlbumArtista AlbumArtistaModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "InsertarAlbumArtista";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@IDAlbum", SqlDbType.Int).Value = AlbumArtistaModel.IDAlbum;
                command.Parameters.Add("@IDArtista", SqlDbType.Int).Value = AlbumArtistaModel.IDArtista;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "EliminarAlbumArtista";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@IDAlbumArtista", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Edit(CAlbumArtista AlbumArtistaModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "ActualizarAlbumArtista";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@IDAlbum", SqlDbType.Int).Value = AlbumArtistaModel.IDAlbum;
                command.Parameters.Add("@IDArtista", SqlDbType.Int).Value = AlbumArtistaModel.IDArtista;
                command.Parameters.Add("@IDAlbumArtista", SqlDbType.Int).Value = AlbumArtistaModel.IDAlbumArtista;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IEnumerable<CAlbumArtista> GetAll()
        {
            var tableList = new List<CAlbumArtista>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from AlbumArtista order by IDAlbumArtista asc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var tableModel = new CAlbumArtista();
                        tableModel.IDAlbumArtista = (int)reader[0];
                        tableModel.IDAlbum = (int)reader[1];
                        tableModel.IDArtista = (int)reader[2];
                        tableList.Add(tableModel);
                    }
                }
                connection.Close();
            }
            return tableList;
        }

        public (List<int>, List<int>) GetAllIDs()
        {
            var foraignArtist = new List<int>();
            var foraignGenre = new List<int>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select IDArtista from Artistas order by IDArtista asc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new CArtistas();
                        userModel.IDArtista = (int)reader[0];
                        foraignArtist.Add(userModel.IDArtista);
                    }
                }
                connection.Close();
                connection.Open();
                command.CommandText = "Select IDAlbum from Albumes order by IDAlbum asc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new CAlbumes();
                        userModel.IDAlbum = (int)reader[0];
                        foraignGenre.Add(userModel.IDAlbum);
                    }
                }
                connection.Close();
            }
            return (foraignArtist, foraignGenre);
        }


        public IEnumerable<CAlbumArtista> GetByValue(string value)
        {
            var tableList = new List<CAlbumArtista>();
            int ID = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select * from AlbumArtista 
                                        where IDAlbumArtista = @IDAlbumArtista'
                                        order by IDAlbumArtista asc";
                //command.Parameters.Add("@IDArtista", SqlDbType.Int).Value = ID;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var tableModel = new CAlbumArtista();
                        tableModel.IDAlbumArtista = (int)reader[0];
                        tableModel.IDAlbum = (int)reader[1];
                        tableModel.IDArtista = (int)reader[2];
                        tableList.Add(tableModel);
                    }
                }
                connection.Close();
            }
            return tableList;
        }
    }


    public class AlbumRepository : BaseRepository, IAlbum
    {
        // Constructor
        public AlbumRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Methods
        public void Add(CAlbumes AlbumesModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "InsertarAlbum";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Titulo", SqlDbType.NVarChar).Value = AlbumesModel.Titulo;
                command.Parameters.Add("@fechaLanzamiento", SqlDbType.Date).Value = AlbumesModel.fechaLanzamiento;
                command.Parameters.Add("@Imagen", SqlDbType.Image).Value = AlbumesModel.Imagen;
                command.Parameters.Add("@Estado", SqlDbType.Bit).Value = AlbumesModel.Estado;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "EliminarAlbum";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@IDAlbum", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Edit(CAlbumes AlbumesModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "ActualizarAlbum";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Titulo", SqlDbType.NVarChar).Value = AlbumesModel.Titulo;
                command.Parameters.Add("@Imagen", SqlDbType.Image).Value = AlbumesModel.Imagen;
                command.Parameters.Add("@fechaLanzamiento", SqlDbType.Date).Value = AlbumesModel.fechaLanzamiento;
                command.Parameters.Add("@Estado", SqlDbType.Bit).Value = AlbumesModel.Estado;
                command.Parameters.Add("@IDAlbum", SqlDbType.Int).Value = AlbumesModel.IDAlbum;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IEnumerable<CAlbumes> GetAll()
        {
            var tableList = new List<CAlbumes>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from Albumes order by IDAlbum asc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var tableModel = new CAlbumes();
                        tableModel.IDAlbum = (int)reader[0];
                        tableModel.Titulo = reader[1].ToString();
                        tableModel.fechaLanzamiento = reader[2].ToString();
                        tableModel.Imagen = (byte[])reader[3];
                        tableModel.Estado = (byte)(reader[4] as bool? == true ? 1 : 0);
                        tableList.Add(tableModel);
                    }
                }
                connection.Close();
            }
            return tableList;
        }

        public (List<int>, List<int>) GetAllIDs()
        {
            var foraignArtist = new List<int>();
            var foraignGenre = new List<int>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select IDArtista from Artistas order by IDArtista asc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new CArtistas();
                        userModel.IDArtista = (int)reader[0];
                        foraignArtist.Add(userModel.IDArtista);
                    }
                }
                connection.Close();
                connection.Open();
                command.CommandText = "Select IDGenero from Generos order by IDGenero asc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new CGeneros();
                        userModel.IDGenero = (int)reader[0];
                        foraignGenre.Add(userModel.IDGenero);
                    }
                }
                connection.Close();
            }
            return (foraignArtist, foraignGenre);
        }

        public IEnumerable<CAlbumes> GetByValue(string value)
        {
            var tableList = new List<CAlbumes>();
            int ID = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string tableName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select * from Albumes
                                        where IDAlbum = @IDAlbum or Titulo like @Titulo+'%'
                                        order by IDAlbum asc";
                command.Parameters.Add("@IDAlbum", SqlDbType.Int).Value = ID;
                command.Parameters.Add("@Titulo", SqlDbType.NVarChar).Value = tableName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var tableModel = new CAlbumes();
                        tableModel.IDAlbum = (int)reader[0];
                        tableModel.Titulo = reader[1].ToString();
                        tableModel.fechaLanzamiento = reader[2].ToString();
                        tableModel.Imagen = (byte[])reader[3];
                        tableModel.Estado = (byte)(reader[4] as bool? == true ? 1 : 0);
                        tableList.Add(tableModel);
                    }
                }
                connection.Close();
            }
            return tableList;
        }
    }

    public class AlbumGenreRepository : BaseRepository, IAlbumGenero
    {
        // Constructor
        public AlbumGenreRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Methods
        public void Add(CAlbumGenero AlbumGeneroModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "InsertarAlbumGenero";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@IDGenero", SqlDbType.Int).Value = AlbumGeneroModel.IDGenero;
                command.Parameters.Add("@IDAlbum", SqlDbType.Int).Value = AlbumGeneroModel.IDAlbum;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "EliminarAlbumGenero";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@IDAlbumGenero", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Edit(CAlbumGenero AlbumGeneroModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "ActualizarAlbumGenero";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@IDGenero", SqlDbType.Int).Value = AlbumGeneroModel.IDGenero;
                command.Parameters.Add("@IDAlbum", SqlDbType.Int).Value = AlbumGeneroModel.IDAlbum;
                command.Parameters.Add("@IDAlbumGenero", SqlDbType.Int).Value = AlbumGeneroModel.IDAlbumGenero;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IEnumerable<CAlbumGenero> GetAll()
        {
            var tableList = new List<CAlbumGenero>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from AlbumGenero order by IDAlbumGenero asc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var tableModel = new CAlbumGenero();
                        tableModel.IDAlbumGenero = (int)reader[0];
                        tableModel.IDGenero = (int)reader[1];
                        tableModel.IDAlbum = (int)reader[2];
                        tableList.Add(tableModel);
                    }
                }
                connection.Close();
            }
            return tableList;
        }

        public (List<int>, List<int>) GetAllIDs()
        {
            var foraignArtist = new List<int>();
            var foraignGenre = new List<int>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select IDGenero from Generos order by IDGenero asc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new CGeneros();
                        userModel.IDGenero = (int)reader[0];
                        foraignArtist.Add(userModel.IDGenero);
                    }
                }
                connection.Close();
                connection.Open();
                command.CommandText = "Select IDAlbum from Albumes order by IDAlbum asc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new CAlbumes();
                        userModel.IDAlbum = (int)reader[0];
                        foraignGenre.Add(userModel.IDAlbum);
                    }
                }
                connection.Close();
            }
            return (foraignArtist, foraignGenre);
        }


        public IEnumerable<CAlbumGenero> GetByValue(string value)
        {
            var tableList = new List<CAlbumGenero>();
            int ID = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select * from AlbumGenero 
                                        where IDAlbumGenero = @IDAlbumGenero'
                                        order by IDAlbumGenero asc";
                //command.Parameters.Add("@IDGenero", SqlDbType.Int).Value = ID;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var tableModel = new CAlbumGenero();
                        tableModel.IDAlbumGenero = (int)reader[0];
                        tableModel.IDGenero = (int)reader[1];
                        tableModel.IDAlbum = (int)reader[2];
                        tableList.Add(tableModel);
                    }
                }
                connection.Close();
            }
            return tableList;
        }
    }

    public class SongGenreRepository : BaseRepository, ICancionGenero
    {
        // Constructor
        public SongGenreRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Methods
        public void Add(CCancionGenero CancionGeneroModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "InsertarCancionGenero";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@IDGenero", SqlDbType.Int).Value = CancionGeneroModel.IDGenero;
                command.Parameters.Add("@IDCancion", SqlDbType.Int).Value = CancionGeneroModel.IDCancion;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "EliminarCancionGenero";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@IDCancionGenero", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Edit(CCancionGenero CancionGeneroModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "ActualizarCancionGenero";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@IDGenero", SqlDbType.Int).Value = CancionGeneroModel.IDGenero;
                command.Parameters.Add("@IDCancion", SqlDbType.Int).Value = CancionGeneroModel.IDCancion;
                command.Parameters.Add("@IDCancionGenero", SqlDbType.Int).Value = CancionGeneroModel.IDCancionGenero;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IEnumerable<CCancionGenero> GetAll()
        {
            var tableList = new List<CCancionGenero>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from CancionGenero order by IDCancionGenero asc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var tableModel = new CCancionGenero();
                        tableModel.IDCancionGenero = (int)reader[0];
                        tableModel.IDGenero = (int)reader[1];
                        tableModel.IDCancion = (int)reader[2];
                        tableList.Add(tableModel);
                    }
                }
                connection.Close();
            }
            return tableList;
        }

        public (List<int>, List<int>) GetAllIDs()
        {
            var foraignArtist = new List<int>();
            var foraignGenre = new List<int>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select IDGenero from Generos order by IDGenero asc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new CGeneros();
                        userModel.IDGenero = (int)reader[0];
                        foraignArtist.Add(userModel.IDGenero);
                    }
                }
                connection.Close();
                connection.Open();
                command.CommandText = "Select IDCancion from Canciones order by IDCancion asc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new CCanciones();
                        userModel.IDCancion = (int)reader[0];
                        foraignGenre.Add(userModel.IDCancion);
                    }
                }
                connection.Close();
            }
            return (foraignArtist, foraignGenre);
        }


        public IEnumerable<CCancionGenero> GetByValue(string value)
        {
            var tableList = new List<CCancionGenero>();
            int ID = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select * from CancionGenero 
                                        where IDCancionGenero = @IDCancionGenero'
                                        order by IDCancionGenero asc";
                //command.Parameters.Add("@IDGenero", SqlDbType.Int).Value = ID;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var tableModel = new CCancionGenero();
                        tableModel.IDCancionGenero = (int)reader[0];
                        tableModel.IDGenero = (int)reader[1];
                        tableModel.IDCancion = (int)reader[2];
                        tableList.Add(tableModel);
                    }
                }
                connection.Close();
            }
            return tableList;
        }

    }

    public class InicioRepository : BaseRepository, IInicio
    {
        // Constructor
        public InicioRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<UCInicio> GetAllUserControl()
        {
            var tableList = new List<UCInicio>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "ArrojarAlbumInfo";
                command.CommandType = CommandType.StoredProcedure;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new UCInicio();
                        userModel.IDAlbum = (int)reader[0];
                        userModel.Titulo = reader[1].ToString();
                        userModel.Año = reader[2].ToString();
                        var bytes = (byte[])reader[3];
                        using (var ms = new System.IO.MemoryStream(bytes))
                        {
                            userModel.Imagen = Image.FromStream(ms);
                        }
                        userModel.Genero = reader[4].ToString();
                        userModel.Artista = reader[5].ToString();
                        tableList.Add(userModel);
                    }
                }
                connection.Close();
            }
            return tableList;
        }

        public IEnumerable<UCInicio> GetAlbumInfo()
        {
            var infoList = new List<UCInicio>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "ArrojarAlbumInfo";
                command.CommandType = CommandType.StoredProcedure;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var Inicio = new UCInicio();
                        Inicio.IDAlbum = (int)reader[0];
                        Inicio.Año = reader[1].ToString();
                        Inicio.Genero = reader[2].ToString();
                        Inicio.Artista = reader[3].ToString();
                        infoList.Add(Inicio);
                    }
                }
                connection.Close();
            }
            return infoList;
        }
    }
    public class CancionesRepository : BaseRepository, ICanciones
    {
        // Constructor
        public CancionesRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Methods
        public void Add(CCanciones usuariosModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "InsertarCanciones";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@IDAlbum", SqlDbType.Int).Value = usuariosModel.IDAlbum;
                command.Parameters.Add("@Titulo", SqlDbType.NVarChar).Value = usuariosModel.Titulo;
                command.Parameters.Add("@Duracion", SqlDbType.NVarChar).Value = usuariosModel.Duracion;
                command.Parameters.Add("@Ruta", SqlDbType.NVarChar).Value = usuariosModel.Ruta;
                command.Parameters.Add("@Estado", SqlDbType.Int).Value = usuariosModel.Estado;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "EliminarCanciones";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Edit(CCanciones usuariosModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                //command.CommandText = @"Update Usuarios 
                //                        set IDPerfil = @IDPerfil, apellidoPaterno = @apellidoPaterno, apellidoMaterno = @apellidoMaterno, Nombre = @Nombre, correoElectronico = @correoElectronico, Contraseña = @Contraseña
                //                        where IDUsuario = @IDUsuario";
                command.CommandText = "ActualizarCanciones";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@IDAlbum", SqlDbType.Int).Value = usuariosModel.IDAlbum;
                command.Parameters.Add("@Titulo", SqlDbType.NVarChar).Value = usuariosModel.Titulo;
                command.Parameters.Add("@Duracion", SqlDbType.NVarChar).Value = usuariosModel.Duracion;
                command.Parameters.Add("@Ruta", SqlDbType.NVarChar).Value = usuariosModel.Ruta;
                command.Parameters.Add("@Estado", SqlDbType.Int).Value = usuariosModel.Estado;
                command.Parameters.Add("@IDCancion", SqlDbType.Int).Value = usuariosModel.IDCancion;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IEnumerable<CCanciones> GetAll()
        {
            var userList = new List<CCanciones>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from Canciones order by IDCancion asc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new CCanciones();
                        userModel.IDCancion = (int)reader[0];
                        userModel.IDAlbum = (int)reader[1];
                        userModel.Titulo = reader[2].ToString();
                        userModel.Duracion = (int)reader[3];
                        userModel.Ruta = reader[4].ToString();
                        userModel.Estado = (byte)(reader[5] as bool? == true ? 1 : 0);
                        userList.Add(userModel);
                    }
                }
                connection.Close();
            }
            return userList;
        }

        public IEnumerable<CCanciones> GetByValue(string value)
        {
            var userList = new List<CCanciones>();
            int ID = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string userName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select * from Canciones 
                                        where IDCancion = @IDCancion or Titulo like @Titulo+'%'
                                        order by IDCancion asc";
                command.Parameters.Add("@IDCancion", SqlDbType.Int).Value = ID;
                command.Parameters.Add("@Titulo", SqlDbType.NVarChar).Value = userName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new CCanciones();
                        userModel.IDCancion = (int)reader[0];
                        userModel.IDAlbum = (int)reader[1];
                        userModel.Titulo = reader[2].ToString();
                        userModel.Duracion = (int)reader[3];
                        userModel.Ruta = reader[4].ToString();
                        userModel.Estado = (byte)(reader[5] as bool? == true ? 1 : 0);
                        userList.Add(userModel);
                    }
                }
                connection.Close();
            }
            return userList;
        }

        public List<int> GetAllIDs()
        {
            var foraignList = new List<int>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select IDAlbum from Albumes order by IDAlbum asc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new CAlbumes();
                        userModel.IDAlbum = (int)reader[0];
                        foraignList.Add(userModel.IDAlbum);
                    }
                }
                connection.Close();
            }
            return foraignList;
        }
    }

    public class ListaCancionRepository : BaseRepository, IListaCancion
    {
        // Constructor
        public ListaCancionRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Methods
        public void Add(CListaCancion ListaCancionModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "InsertarListaCancion";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@IDLista", SqlDbType.Int).Value = ListaCancionModel.IDLista;
                command.Parameters.Add("@IDCancion", SqlDbType.Int).Value = ListaCancionModel.IDCancion;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "EliminarListaCancion";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@IDListaCancion", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Edit(CListaCancion ListaCancionModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "ActualizarListaCancion";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@IDLista", SqlDbType.Int).Value = ListaCancionModel.IDLista;
                command.Parameters.Add("@IDCancion", SqlDbType.Int).Value = ListaCancionModel.IDCancion;
                command.Parameters.Add("@IDListaCancion", SqlDbType.Int).Value = ListaCancionModel.IDListaCancion;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IEnumerable<CListaCancion> GetAll()
        {
            var tableList = new List<CListaCancion>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from ListaCancion order by IDLista asc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var tableModel = new CListaCancion();
                        tableModel.IDListaCancion = (int)reader[0];
                        tableModel.IDLista = (int)reader[1];
                        tableModel.IDCancion = (int)reader[2];
                        tableList.Add(tableModel);
                    }
                }
                connection.Close();
            }
            return tableList;
        }

        public (List<int>, List<int>) GetAllIDs()
        {
            var foraignArtist = new List<int>();
            var foraignGenre = new List<int>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select IDLista from Listas order by IDLista asc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new CListas();
                        userModel.IDLista = (int)reader[0];
                        foraignArtist.Add(userModel.IDLista);
                    }
                }
                connection.Close();
                connection.Open();
                command.CommandText = "Select IDCancion from Canciones order by IDCancion asc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new CCanciones();
                        userModel.IDCancion = (int)reader[0];
                        foraignGenre.Add(userModel.IDCancion);
                    }
                }
                connection.Close();
            }
            return (foraignArtist, foraignGenre);
        }


        public IEnumerable<CListaCancion> GetByValue(string value)
        {
            var tableList = new List<CListaCancion>();
            int ID = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select * from ListaCancion 
                                        where IDListaCancion = @IDListaCancion'
                                        order by IDListaCancion asc";
                //command.Parameters.Add("@IDLista", SqlDbType.Int).Value = ID;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var tableModel = new CListaCancion();
                        tableModel.IDListaCancion = (int)reader[0];
                        tableModel.IDLista = (int)reader[1];
                        tableModel.IDCancion = (int)reader[2];
                        tableList.Add(tableModel);
                    }
                }
                connection.Close();
            }
            return tableList;
        }
    }
    public class AlbumCancionRepository : BaseRepository, IAlbumCancion
    {
        // Constructor
        public AlbumCancionRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Methods
        public void Add(CAlbumCancion AlbumCancionModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "InsertarAlbumCancion";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@IDAlbum", SqlDbType.Int).Value = AlbumCancionModel.IDAlbum;
                command.Parameters.Add("@IDCancion", SqlDbType.Int).Value = AlbumCancionModel.IDCancion;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "EliminarAlbumCancion";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@IDAlbumCancion", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Edit(CAlbumCancion AlbumCancionModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "ActualizarAlbumCancion";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@IDAlbum", SqlDbType.Int).Value = AlbumCancionModel.IDAlbum;
                command.Parameters.Add("@IDCancion", SqlDbType.Int).Value = AlbumCancionModel.IDCancion;
                command.Parameters.Add("@IDAlbumCancion", SqlDbType.Int).Value = AlbumCancionModel.IDAlbumCancion;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IEnumerable<CAlbumCancion> GetAll()
        {
            var tableList = new List<CAlbumCancion>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from AlbumCancion order by IDAlbum asc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var tableModel = new CAlbumCancion();
                        tableModel.IDAlbumCancion = (int)reader[0];
                        tableModel.IDAlbum = (int)reader[1];
                        tableModel.IDCancion = (int)reader[2];
                        tableList.Add(tableModel);
                    }
                }
                connection.Close();
            }
            return tableList;
        }

        public (List<int>, List<int>) GetAllIDs()
        {
            var foraignArtist = new List<int>();
            var foraignGenre = new List<int>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select IDAlbum from Album order by IDAlbum asc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new CAlbumes();
                        userModel.IDAlbum = (int)reader[0];
                        foraignArtist.Add(userModel.IDAlbum);
                    }
                }
                connection.Close();
                connection.Open();
                command.CommandText = "Select IDCancion from Canciones order by IDCancion asc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new CCanciones();
                        userModel.IDCancion = (int)reader[0];
                        foraignGenre.Add(userModel.IDCancion);
                    }
                }
                connection.Close();
            }
            return (foraignArtist, foraignGenre);
        }


        public IEnumerable<CAlbumCancion> GetByValue(string value)
        {
            var tableList = new List<CAlbumCancion>();
            int ID = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select * from AlbumCancion 
                                        where IDAlbumCancion = @IDAlbumCancion'
                                        order by IDAlbumCancion asc";
                //command.Parameters.Add("@IDAlbum", SqlDbType.Int).Value = ID;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var tableModel = new CAlbumCancion();
                        tableModel.IDAlbumCancion = (int)reader[0];
                        tableModel.IDAlbum = (int)reader[1];
                        tableModel.IDCancion = (int)reader[2];
                        tableList.Add(tableModel);
                    }
                }
                connection.Close();
            }
            return tableList;
        }
    }
    public class ListasRepository : BaseRepository, IListas
    {
        // Constructor
        public ListasRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Methods
        public void Add(CListas usuariosModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "InsertarLista";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@IDUsuario", SqlDbType.Int).Value = usuariosModel.IDUsuario;
                command.Parameters.Add("@Titulo", SqlDbType.NVarChar).Value = usuariosModel.Titulo;
                command.Parameters.Add("@Descripcion", SqlDbType.NVarChar).Value = usuariosModel.Descripcion;
                command.Parameters.Add("@Estado", SqlDbType.Int).Value = usuariosModel.Estado;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "EliminarLista";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Edit(CListas usuariosModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                //command.CommandText = @"Update Usuarios 
                //                        set IDPerfil = @IDPerfil, apellidoPaterno = @apellidoPaterno, apellidoMaterno = @apellidoMaterno, Nombre = @Nombre, correoElectronico = @correoElectronico, Contraseña = @Contraseña
                //                        where IDUsuario = @IDUsuario";
                command.CommandText = "ActualizarListas";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@IDUsuario", SqlDbType.Int).Value = usuariosModel.IDUsuario;
                command.Parameters.Add("@Titulo", SqlDbType.NVarChar).Value = usuariosModel.Titulo;
                command.Parameters.Add("@Descripcion", SqlDbType.NVarChar).Value = usuariosModel.Descripcion;
                command.Parameters.Add("@Estado", SqlDbType.Int).Value = usuariosModel.Estado;
                command.Parameters.Add("@IDLista", SqlDbType.Int).Value = usuariosModel.IDLista;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IEnumerable<CListas> GetAll()
        {
            var userList = new List<CListas>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from Listas order by IDLista asc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new CListas();
                        userModel.IDLista = (int)reader[0];
                        userModel.IDUsuario = (int)reader[1];
                        userModel.Titulo = reader[2].ToString();
                        userModel.Descripcion = reader[3].ToString();
                        userModel.fechaRegistro = reader[4].ToString();
                        userModel.Estado = (byte)(reader[5] as bool? == true ? 1 : 0);
                        userList.Add(userModel);
                    }
                }
                connection.Close();
            }
            return userList;
        }

        public IEnumerable<CListas> GetByValue(string value)
        {
            var userList = new List<CListas>();
            int ID = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string userName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select * from Listas
                                        where IDLista = @IDLista or Titulo like @Titulo+'%'
                                        order by IDLista asc";
                command.Parameters.Add("@IDLista", SqlDbType.Int).Value = ID;
                command.Parameters.Add("@Titulo", SqlDbType.NVarChar).Value = userName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new CListas();
                        userModel.IDLista = (int)reader[0];
                        userModel.IDUsuario = (int)reader[1];
                        userModel.Titulo = reader[2].ToString();
                        userModel.Descripcion = reader[3].ToString();
                        userModel.fechaRegistro = reader[4].ToString();
                        userModel.Estado = (byte)(reader[5] as bool? == true ? 1 : 0);
                        userList.Add(userModel);
                    }
                }
                connection.Close();
            }
            return userList;
        }

        public List<int> GetAllIDs()
        {
            var foraignList = new List<int>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select IDUsuario from Usuarios order by IDUsuario asc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new CUsuarios();
                        userModel.IDUsuario = (int)reader[0];
                        foraignList.Add(userModel.IDUsuario);
                    }
                }
                connection.Close();
            }
            return foraignList;
        }
    }
}