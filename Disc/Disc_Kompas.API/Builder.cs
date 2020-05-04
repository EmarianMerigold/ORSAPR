using Disc_Kompas.Logic;
using Kompas6API5;
using Kompas6Constants;
using Kompas6Constants3D;

namespace Disc_Kompas.API
{
    public class Builder
    {
        public ksPart iPart;

        ksEntity iSketch;

        ksSketchDefinition iDefinitionSketch;

        /// <summary>
        /// Функция, которая выполняет все элементы построения.
        /// </summary>
        /// <param name="iPart"> интерфейс детали </param>
        /// <param name="kompas">  объект типа kompas </param>
        /// <param name="discparams"> класс, хранящий параметры диска </param>
        public void Build(ksPart iPart, KompasObject kompas, DiscParams discparams, bool Edge)
        {
            this.iPart = iPart;
            CreateDisc(iPart, kompas, discparams);
            CreateHole(iPart, kompas, discparams);
            CreateFrontCut(iPart, kompas, discparams);
            CreateBackCut(iPart, kompas, discparams);
            CreateRounding(iPart, kompas, discparams);

            if (Edge)
                CreateEdge(iPart, kompas, discparams);
                CreateHole(iPart, kompas, discparams);

        }

        /// <summary>
        /// Функция выполняет построение основного диска.
        /// </summary>
        public void CreateDisc(ksPart iPart, KompasObject kompas, DiscParams discParams)
        {
            int thickness = discParams.Width;

            int radius = discParams.MainDiameter / 2;

            CreateSketch(out iSketch, out iDefinitionSketch);

            ksDocument2D iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();

            iDocument2D.ksCircle(0, 0, radius, 1);

            iDefinitionSketch.EndEdit();

            ExctrusionSketch(iPart, iSketch, thickness, true);
        }

        /// <summary>
        /// Функция создает центральное отверстие в диске
        /// </summary>
        private void CreateHole(ksPart iPart, KompasObject kompas, DiscParams discParams)
        {
            double offset = discParams.Width;

            double radius = discParams.InsideDiameter / 2;

            CreateSketch(out iSketch, out iDefinitionSketch, offset);

            ksDocument2D iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();

            iDocument2D.ksCircle(0, 0, radius, 1);

            iDefinitionSketch.EndEdit();

            ksEntity entityCutExtr = (ksEntity)iPart.NewEntity((short)Obj3dType.o3d_cutExtrusion);
            ksCutExtrusionDefinition cutExtrDef = 
                (ksCutExtrusionDefinition)entityCutExtr.GetDefinition();
            cutExtrDef.SetSketch(iSketch);
            cutExtrDef.directionType = (short)Direction_Type.dtNormal; 
            cutExtrDef.SetSideParam(true, (short)End_Type.etBlind, discParams.Width, 0, false);
            cutExtrDef.SetThinParam(false, 0, 0, 0);
            entityCutExtr.Create();

        }

        /// <summary>
        /// Функция создает вырез грани с лицевой стороны диска.
        /// </summary>
        private void CreateFrontCut(ksPart iPart, KompasObject kompas, DiscParams discParams)
        {
            double offset = discParams.Width;

            double radius = discParams.CentralCut / 2;

            CreateSketch(out iSketch, out iDefinitionSketch, offset);

            ksDocument2D iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();

            iDocument2D.ksCircle(0, 0, radius, 1);

            iDefinitionSketch.EndEdit();

            ksEntity entityCutExtr = 
                (ksEntity)iPart.NewEntity((short)Obj3dType.o3d_cutExtrusion);
            ksCutExtrusionDefinition cutExtrDef = 
                (ksCutExtrusionDefinition)entityCutExtr.GetDefinition();
            cutExtrDef.SetSketch(iSketch);
            cutExtrDef.directionType = (short)Direction_Type.dtNormal;
            cutExtrDef.SetSideParam(true, (short)End_Type.etBlind, discParams.DepthCut, 0, false);
            cutExtrDef.SetThinParam(false, 0, 0, 0);
            entityCutExtr.Create();

        }

        /// <summary>
        /// Функция создает вырез грани с тыльной стороны диска.
        /// </summary>
        private void CreateBackCut(ksPart iPart, KompasObject kompas, DiscParams discParams)
        {
            double offset = discParams.DepthCut;

            double radius = discParams.CentralCut / 2;

            CreateSketch(out iSketch, out iDefinitionSketch, offset);

            ksDocument2D iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();

            iDocument2D.ksCircle(0, 0, radius, 1);

            iDefinitionSketch.EndEdit();

            ksEntity entityCutExtr = 
                (ksEntity)iPart.NewEntity((short)Obj3dType.o3d_cutExtrusion);
            ksCutExtrusionDefinition cutExtrDef = 
                (ksCutExtrusionDefinition)entityCutExtr.GetDefinition();
            cutExtrDef.SetSketch(iSketch);
            cutExtrDef.directionType = (short)Direction_Type.dtNormal;
            cutExtrDef.SetSideParam(true, (short)End_Type.etBlind, discParams.DepthCut, 0, false);
            cutExtrDef.SetThinParam(false, 0, 0, 0);
            entityCutExtr.Create();

        }

        /// <summary>
        /// Функция выполняет скругление рёбер диска.
        /// </summary>
        private void CreateRounding(ksPart iPart, KompasObject kompas, DiscParams discParams)
        {
            double radius = discParams.Angle;

            ksEntity entityFillet = (ksEntity)iPart.NewEntity((short)Obj3dType.o3d_fillet);

            ksFilletDefinition filletDef = (ksFilletDefinition)entityFillet.GetDefinition();

            filletDef.radius = radius;
            filletDef.tangent = false;
            ksEntityCollection collect = 
                (ksEntityCollection)iPart.EntityCollection((short)Obj3dType.o3d_face);
            ksEntityCollection arr = 
                (ksEntityCollection)filletDef.array();
            arr.Add(collect.GetByIndex(2));
            arr.Add(collect.GetByIndex(0));

            entityFillet.Create();
        }

        /// <summary>
        /// Функция выполняет построение основы кромки диска.
        /// </summary>
        public void CreateEdge(ksPart iPart, KompasObject kompas, DiscParams discParams)
        {
            int thickness = discParams.Width;

            int radius = (discParams.InsideDiameter / 2) + 10;

            CreateSketch(out iSketch, out iDefinitionSketch);

            ksDocument2D iDocument2D = (ksDocument2D)iDefinitionSketch.BeginEdit();

            iDocument2D.ksCircle(0, 0, radius, 1);

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

            ksEntity iPlane = 
                (ksEntity)iPart.NewEntity((short)Obj3dType.o3d_planeOffset);

            ksPlaneOffsetDefinition iPlaneDefinition = 
                (ksPlaneOffsetDefinition)iPlane.GetDefinition();

            iPlaneDefinition.SetPlane(iPart.GetDefaultEntity((short)Obj3dType.o3d_planeXOZ));
            iPlaneDefinition.direction = true;
            iPlaneDefinition.offset = offset;
            iPlane.Create();
            #endregion --------------------------------------------------

            iSketch = (ksEntity)iPart.NewEntity((short)Obj3dType.o3d_sketch);

            iDefinitionSketch = iSketch.GetDefinition();

            iDefinitionSketch.SetPlane(iPlane);
 
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
            ksEntity entityExtr = (ksEntity)iPart.NewEntity((short)Obj3dType.o3d_bossExtrusion);

            ksBossExtrusionDefinition extrusionDef = (ksBossExtrusionDefinition)entityExtr.GetDefinition();

            ksExtrusionParam extrProp = (ksExtrusionParam)extrusionDef.ExtrusionParam();

            extrusionDef.SetSketch(iSketch);

            if (direction == false)
            {
                extrProp.direction = (short)Direction_Type.dtReverse;
            }
            else
            {
                extrProp.direction = (short)Direction_Type.dtNormal;
            }

            extrProp.typeNormal = (short)End_Type.etBlind;

            if (direction == false)
            {
                extrProp.depthReverse = depth;
            }
            else
            {
                extrProp.depthNormal = depth;
            }

            entityExtr.Create();
        }
    }
}
