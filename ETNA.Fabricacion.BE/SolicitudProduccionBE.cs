using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntitiesLayer
{
    public class SolicitudProduccionBE
    {

        private string _IdSolicitud;

        public string IdSolicitud
        {
            get
            {
                return _IdSolicitud;
            }
            set
            {
                _IdSolicitud = value;
            }
        }

        private DateTime _FechaSolicitud;

        public DateTime FechaSolicitud
        {
            get
            {
                return _FechaSolicitud;
            }
            set
            {
                _FechaSolicitud = value;
            }
        }

        private string _Descripcion;

        public string Descripcion
        {
            get
            {
                return _Descripcion;
            }
            set
            {
                _Descripcion = value;
            }
        }


        private int _IdPlan;

        public int IdPlan
        {
            get
            {
                return _IdPlan;
            }
            set
            {
                _IdPlan = value;
            }
        }

        private int _CantidadMaquinaria;

        public int CantidadMaquinaria
        {
            get
            {
                return _CantidadMaquinaria;
            }
            set
            {
                _CantidadMaquinaria = value;
            }
        }

        private int _CantidadInsumos;

        public int CantidadInsumos
        {
            get
            {
                return _CantidadInsumos;
            }
            set
            {
                _CantidadInsumos = value;
            }
        }

        private int _CantidadPersonal;

        public int CantidadPersonal
        {
            get
            {
                return _CantidadPersonal;
            }
            set
            {
                _CantidadPersonal = value;
            }
        }

        private string _Glosa;

        public string Glosa
        {
            get
            {
                return _Glosa;
            }
            set
            {
                _Glosa = value;
            }
        }

    }
}
