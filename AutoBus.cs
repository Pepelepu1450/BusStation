using System;

namespace bus_station
{
        class AutoBus{
            public string nombreDelConductor { get; set; }
            public char rutaDelCamion { get; set; }
            public AutoBus (string nombreDelConductor, char rutaDelCamion){
                this.nombreDelConductor = nombreDelConductor;
                this.rutaDelCamion = rutaDelCamion;
            }
            
            public string tomarNombreDelConductor(){
                return nombreDelConductor;
            }

            public char tomarRutaDelCamion(){
                return rutaDelCamion;
            }
    }
    
}
