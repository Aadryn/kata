# Kata - .Net  - Sensor
---
## Description:
This kata aims to implement the behavior of an alarm that retrieves a sensor's data.
Your goal is to respect the rules describe below.

### Global Rules :
1. Only the implementation of the **Alarm** can be called with implemented behavior.
2. No extra fields, properties, methods, indexers, can be added to the **Sensor** class.

### Alarm Behavior rules :
1. When the Alarm is initialized the **Status** must be off.
2. When the sensor value is below -21 the **Status** must be on.
3. When the sensor value is past 21 the **Status** must be off.
4. When the sensor is between -21 and 21 the **Status** must be off.