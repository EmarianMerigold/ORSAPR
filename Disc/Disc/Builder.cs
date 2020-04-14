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
        /// <param name="discparams"> класс, хранящий параметры улья</param>
        public void Build(ksPart iPart, KompasObject kompas, DiscParams discparams)
        {
            this.iPart = iPart;
            CreateDisc(iPart, kompas, discparams);
        }


        /// <summary>
        /// Функция выполняет построение основного диска.
        /// </summary>
        public void CreateDisc(ksPart iPart, KompasObject kompas, DiscParams discParams)
        {
            //Толщина диска
            int thickness = discParams.Width;
            //Радиус диска
            int radius = discParams.MainDiameter / 2;
            ksEntity iSketch;

            ksSketchDefinition iDefinitionSketch;

            CreateSketch(out iSketch, out iDefinitionSketch);

            // Интерфейс для рисования = на скетче;
            ksDocument2D iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();

            iDocument2D.ksCircle(0, 0, radius, 1);

            // Закончить редактировать эскиз
            iDefinitionSketch.EndEdit();

            ExctrusionSketch(iPart, iSketch, thickness, true);
        }

        /// <summary>
        /// Создать эскиз
        /// </summary>
        /// <param name="iSketch">Эскиз</param>
        /// <param name="iDefinitionSketch">Определение эскиза</param>
        /// <param name="offset">Смещение от начальной плоскости</param>
        private void CreateSketch(out ksEntity iSketch, out ksSketchDefinition iDefinitionSketch, double offset = 0)
        {
            #region Создание смещенную плоскость -------------------------
            // интерфейс смещенной плоскости
            ksEntity iPlane = (ksEntity)iPart.NewEntity((short)Obj3dType.o3d_planeOffset);

            // Получаем интрефейс настроек смещенной плоскости
            ksPlaneOffsetDefinition iPlaneDefinition = (ksPlaneOffsetDefinition)iPlane.GetDefinition();

            // Настройки : начальная позиция, направление смещения, расстояние от плоскости, принять все настройки (create)
            iPlaneDefinition.SetPlane(iPart.GetDefaultEntity((short)Obj3dType.o3d_planeXOZ));
            iPlaneDefinition.direction = true;
            iPlaneDefinition.offset = offset;
            iPlane.Create();
            #endregion --------------------------------------------------

            // Создаем обьект эскиза
            iSketch = (ksEntity)iPart.NewEntity((short)Obj3dType.o3d_sketch);

            // Получаем интерфейс настроек эскиза
            iDefinitionSketch = iSketch.GetDefinition();

            // Устанавливаем плоскость эскиза
            iDefinitionSketch.SetPlane(iPlane);

            // Теперь когда св-ва эскиза установлены можно его создать 
            iSketch.Create();
        }

        /// <summary>
        /// Выдавливание по эскизу
        /// </summary>
        /// <param name="iPart">Интерфейс детали</param>
        /// <param name="iSketch">Эскиз</param>
        /// <param name="depth">Глубина выдавливания</param>
        /// <param name="direction">Направление выдавливания</param>
        private void ExctrusionSketch(ksPart iPart, ksEntity iSketch, double depth, bool direction)
        {
            //Операция выдавливание
            ksEntity entityExtr = (ksEntity)iPart.NewEntity((short)Obj3dType.o3d_bossExtrusion);

            //Интерфейс операции выдавливания
            ksBossExtrusionDefinition extrusionDef = (ksBossExtrusionDefinition)entityExtr.GetDefinition();

            //Интерфейс структуры параметров выдавливания
            ksExtrusionParam extrProp = (ksExtrusionParam)extrusionDef.ExtrusionParam();

            //Эскиз операции выдавливания
            extrusionDef.SetSketch(iSketch);

            //Направление выдавливания
            if (direction == false)
            {
                extrProp.direction = (short)Direction_Type.dtReverse;
            }
            else
            {
                extrProp.direction = (short)Direction_Type.dtNormal;
            }

            //Тип выдавливания
            extrProp.typeNormal = (short)End_Type.etBlind;

            //Глубина выдавливания
            if (direction == false)
            {
                extrProp.depthReverse = depth;
            }
            else
            {
                extrProp.depthNormal = depth;
            }
            //Создание операции выдавливания
            entityExtr.Create();
        }
    }
}
