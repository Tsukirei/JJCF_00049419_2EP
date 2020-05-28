namespace Parcial_2
{
    public class Appusuario
    {
        public int iduser { get; set; }
        public string usuario { get; set; }

        public string nombre { get; set; }
        public string contrasena { get; set; }
        public bool admin { get; set; }
       

        public Appusuario()
        {
            iduser =0;
            usuario = "";
            nombre = "";
            contrasena = "";
            admin = false;
            
        }
    }
}