using System;
using System.ComponentModel;

[Serializable]
public enum AmmunitionType
{
    [Description("Arrow")]
    Arrow,
    [Description("Crossbow Bolt")]
    CrossbowBolt,
    [Description(".32 Handgun")]
    Handgun32,
    [Description("9x18mm Handgun")]
    Handgun9x18mm,
    [Description(".357 Handgun")]
    Handgun357,
    [Description(".38 Handgun")]
    Handgun38,
    [Description("20 Gauge")]
    Shotgun20Gauge,
    [Description("16 Gauge")]
    Shotgun16Gauge,
    [Description("12 Gauge")]
    Shotgun12Gauge,
    [Description("5.45x39mm Rifle")]
    Rifle545,
    [Description("5.56x45mm Rifle")]
    Rifle556,
    [Description("7.62x51mm Rifle")]
    Rifle762
}