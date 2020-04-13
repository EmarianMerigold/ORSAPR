using Kompas6API5;
using Kompas6Constants;
using Kompas6Constants3D;

namespace Disc
{
    class Builder
    {
        //KompasObject kompas;
        public ksPart iPart;
        // public HiveParams HiveParams;
        // public KompasConnector kompas;

        /// <summary>
        /// Функция, которая выполняет построение всех деталей.
        /// </summary>
        /// <param name="iPart"> интерфейс детали</param>
        /// <param name="kompas">  объект типа kompas</param>
        /// <param name="hiveparams"> класс, хранящий параметры улья</param>
        public void Build(ksPart iPart, KompasObject kompas, DiscParams discparams)
        {
            this.iPart = iPart;
            CreateDisc(iPart, kompas, discparams);
        }
        /// <summary>
        /// Функция выполняет построение основной части улья.
        /// </summary>
        public void CreateDisc(ksPart iPart, KompasObject kompas, DiscParams discParams)
        {
            //double thickness = discParams.DiscParams;
            ksEntity iSketch;

            ksSketchDefinition iDefinitionSketch;

           //CreateSketch(out iSketch, out iDefinitionSketch);
            // Интерфейс для рисования = на скетче;
            //ksDocument2D iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();
            // Построить прямоугольник (x1,y1, x2,y2, style)
            ksRectangleParam par1 = (ksRectangleParam)kompas.GetParamStruct((short)StructType2DEnum.ko_RectangleParam);
            par1.ang = 0; //Угол ?
            par1.x = 10;
            par1.y = 10;
            //par1.width = discParams.HiveLength;
            //par1.height = discParams.HiveHeight; // Больше похоже на ширину, нежели высоту.
            par1.style = 1; // При нуле не видно деталь.
            //iDocument2D.ksRectangle(par1);

            // Закончить редактировать эскиз
            //iDefinitionSketch.EndEdit();

           // ExctrusionSketch(iPart, iSketch, thickness, true);
        }
    }
}
