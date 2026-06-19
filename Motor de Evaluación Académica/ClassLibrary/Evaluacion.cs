
namespace ClassLibrary
{
    public abstract class Evaluacion
    {
        private  int _nota;
        public  int Nota { set; get; }
        public string? NombreEstudiante { set; get; }

        private int _notafinal;
        public  int CalificacionFinal { private get; set  ; }


        public abstract void Evaluar();
      

    }
}
