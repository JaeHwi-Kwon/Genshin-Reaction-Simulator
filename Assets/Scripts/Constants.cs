using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Constants
{
    //Aura Tax
    public static readonly float AURA_TAX = 0.8f;

    //Amplifying Reaction Multiplier
    public static readonly float VAPORIZE_HYDRO = 2.0f;
    public static readonly float VAPORIZE_PYRO = 1.5f;
    public static readonly float MELT_PYRO = 2.0f;
    public static readonly float MELT_CRYO = 1.5f;

    //Transformative Reaction Multiplier
    public static readonly float BURGEON = 3.0f;
    public static readonly float HYPERBLOOM = 3.0f;
    public static readonly float OVERLOADED = 2.0f;
    public static readonly float BLOOM = 2.0f;
    public static readonly float SHATTERED = 1.5f;
    public static readonly float ELECTRO_CHARGED = 1.2f;
    public static readonly float SWIRL = 0.6f;
    public static readonly float SUPERCONDUCT = 0.5f;
    public static readonly float BURNING = 0.25f;

    //Additive Reaction Multiplier
    public static readonly float SPREAD = 1.25f;
    public static readonly float AGGRAVATE = 1.15f;

    //RGB Color Code of 7 Elements
    public static readonly Color CRYO       = new Color(160 / 255f, 215 / 255f, 228 / 255f);
    public static readonly Color PYRO       = new Color(239 / 255f, 122 / 255f, 053 / 255f);
    public static readonly Color ELECTRO    = new Color(176 / 255f, 143 / 255f, 194 / 255f);
    public static readonly Color HYDRO      = new Color(075 / 255f, 195 / 255f, 241 / 255f);
    public static readonly Color ANEMO      = new Color(117 / 255f, 195 / 255f, 170 / 255f);
    public static readonly Color GEO        = new Color(250 / 255f, 183 / 255f, 046 / 255f);
    public static readonly Color DENDRO     = new Color(166 / 255f, 501 / 255f, 056 / 255f);

    public static readonly Color[] Elements_Color = 
        new Color[] {   new Color(160 / 255f, 215 / 255f, 228 / 255f),
                        new Color(239 / 255f, 122 / 255f, 053 / 255f),
                        new Color(176 / 255f, 143 / 255f, 194 / 255f),
                        new Color(075 / 255f, 195 / 255f, 241 / 255f),
                        new Color(117 / 255f, 195 / 255f, 170 / 255f),
                        new Color(250 / 255f, 183 / 255f, 046 / 255f),
                        new Color(166 / 255f, 501 / 255f, 056 / 255f)};
}
