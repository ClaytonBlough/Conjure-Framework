using System;
using UnityEngine;

[Serializable]
public enum AmmunitionType
{
    [InspectorName("Arrow")]
    Arrow,
    [InspectorName("Crossbow Bolt")]
    CrossbowBolt,
    [InspectorName(".32 Handgun")]
    Handgun32,
    [InspectorName("9x18mm Handgun")]
    Handgun9x18mm,
    [InspectorName(".357 Handgun")]
    Handgun357,
    [InspectorName(".38 Handgun")]
    Handgun38,
    [InspectorName("20 Gauge")]
    Shotgun20Gauge,
    [InspectorName("16 Gauge")]
    Shotgun16Gauge,
    [InspectorName("12 Gauge")]
    Shotgun12Gauge,
    [InspectorName("5.45x39mm Rifle")]
    Rifle545,
    [InspectorName("5.56x45mm Rifle")]
    Rifle556,
    [InspectorName("7.62x51mm Rifle")]
    Rifle762
}