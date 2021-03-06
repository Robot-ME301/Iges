﻿// Copyright (c) IxMilia.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

namespace IxMilia.Iges.Entities
{
    public enum IgesEntityType
    {
        Null = 0,
        CircularArc = 100,
        CompositeCurve = 102,
        ConicArc = 104,
        CopiousData = 106,
        Plane = 108,
        Line = 110,
        ParametricSplineCurve = 112,
        ParametricSplineSurface = 114,
        Point = 116,
        RuledSurface = 118,
        SurfaceOfRevolution = 120,
        TabulatedCylinder = 122,
        Direction = 123,
        TransformationMatrix = 124,
        Flash = 125,
        RationalBSplineCurve = 126,
        RationalBSplineSurface = 128,
        OffsetCurve = 130,
        ConnectPoint = 132,
        Node = 134,
        FiniteElement = 136,
        NodalDisplacementAndRotation = 138,
        OffsetSurface = 140,
        Boundary = 141,
        CurveOnAParametricSurface = 142,
        BoundedSurface = 143,
        TrimmedParametricSurface = 144,
        NodalResults = 146,
        ElementResults = 148,
        Block = 150,
        RightAngularWedge = 152,
        RightCircularCylinder = 154,
        RightCircularConeFrustrum = 156,
        Sphere = 158,
        Torus = 160,
        SolidOfRevolution = 162,
        SolidOfLinearExtrusion = 164,
        Ellipsoid = 168,
        BooleanTree = 180,
        SelectedComponent = 182,
        SolidAssembly = 184,
        ManifestSolidBRepObject = 186,
        PlaneSurface = 190,
        RightCircularCylindricalSurface = 192,
        RightCircularConicalSurface = 194,
        SphericalSurface = 196,
        ToroidalSurface = 198,
        AngularDimension = 202,
        CurveDimension = 204,
        DiameterDimension = 206,
        FlagNote = 208,
        GeneralLabel = 210,
        GeneralNote = 212,
        NewGeneralNote = 213,
        Leader = 214,
        LinearDimension = 216,
        OrdinateDimension = 218,
        PointDimension = 220,
        RadiusDimension = 222,
        GeneralSymbol = 228,
        LineFontDefinition = 304,
        SubfigureDefinition = 308,
        TextFontDefinition = 310,
        TextDisplayTemplate = 312,
        ColorDefinition = 314,
        AssociativityInstance = 402,
        Property = 406,
        View = 410
    }
}
