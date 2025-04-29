using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MetaForge.Utilities
{
    public class Dictionaries
    {
        static public Dictionary<int, string> MetadataNames = new Dictionary<int, string>
        {
            {1, "Latitud Ref" },
            {2, "Latitud"},
            {3, "Lontigud Ref" },
            {4, "Longitud"},
            {5, "Altitud Ref" },
            {6, "Altitud"},
            {256, "Descripción de la imagen."},
            {257, "Altura de la imagen."},
            {258, "Bits por canal."},
            {259, "Compresión."},
            {262, "Espacio de color."},
            {271, "Fabricante de la cámara."},
            {272, "Modelo de la cámara."},
            {273, "StripsOffsets."},
            {274, "Orientación."},
            {277, "SamplesPerPixel."},
            {278, "RowsPerStrip."},
            {279, "StripByteCounts."},
            {282, "Resolución X."},
            {283, "Resolución Y."},
            {284, "PlanarConfiguration."},
            {296, "Unidad de resolución."},
            {305, "Software."},
            {306, "Fecha y hora de modificación."},
            {315, "Artista."},
            {318, "WhitePoint."},
            {319, "PrimaryChromaticities."},
            {33434, "Tiempo de exposición."},
            {33437, "Número F (Apertura)."},
            {34850, "Modo de exposición."},
            {34852, "Programa de exposición."},
            {34855, "Sensibilidad ISO."},
            {34856, "OECF (Opto-Electric Conversion Function)."},
            {36864, "Versión EXIF."},
            {36867, "Fecha y hora original."},
            {36868, "Fecha y hora digitalizada."},
            {37121, "Configuración de componentes."},
            {37377, "Velocidad del obturador (ShutterSpeedValue)."},
            {37378, "Apertura (ApertureValue)."},
            {37379, "Brillo."},
            {37380, "Sesgo de exposición (ExposureBias)."},
            {37381, "Apertura máxima."},
            {37382, "Distancia al sujeto."},
            {37383, "Modo de medición."},
            {37384, "Fuente de luz."},
            {37385, "Flash."},
            {37386, "Distancia focal."},
            {37500, "MakerNote."},
            {37510, "Comentarios de usuario."},
            {40960, "FlashpixVersion."},
            {40961, "Espacio de color."},
            {40962, "Ancho de imagen válida."},
            {40963, "Altura de imagen válida."},
            {41483, "FlashEnergy."},
            {41484, "SpatialFrequencyResponse."},
            {41486, "FocalPlaneXResolution."},
            {41487, "FocalPlaneYResolution."},
            {41488, "FocalPlaneResolutionUnit."},
            {41492, "Ubicación de captura."},
            {41493, "ExposureIndex."},
            {41495, "SensingMethod."},
            {41728, "Tipo de escena capturada."},
            {41729, "Proceso de captura."},
            {41985, "Modo de exposición personalizada."},
            {41986, "Balance de blancos."},
            {41987, "Modo de medición."},
            {41988, "Ratio de zoom digital."},
            {41989, "Longitud focal en película de 35mm."},
            {41990, "Modo de captura de escena."},
            {41991, "Modo de rango dinámico."},
            {41992, "Modo de balance de blancos."},
            {41993, "Efecto de filtro."},
            {41994, "Modo de toma panorámica."},
            {41995, "Compensación de tono."},
            {41996, "Contraste."},
            {41997, "Saturación."},
            {41998, "Nitidez."},
            {42016, "Identificador único de imagen."}
        };
        static public Dictionary<int, string> Orientacion = new Dictionary<int, string>
        {
            {1, "Normal"},
            {2, "Reflejo horizontal"},
            {3, "Rotación de 180 grados" },
            {4, "Reflejo vertical" },
            {5, "Reflejo a lo largo de la línea que va de la esquina superior izquierda a la inferior derecha"},
            {6, "Reflejo de 90 grados en sentido horario"},
            {7, "Reflejo a lo largo de la línea que va de la esquina superior derecha a la inferior izquierda"},
            {8, "Reflejo de 90 grados en sentido antihorario"}
        };
        static public Dictionary<int, string> AltitudRef = new Dictionary<int, string>
        {
            {0, "Sobre el nivel del mar"},
            {1, "Debajo del nivel del mar" }
        };
    }
}
