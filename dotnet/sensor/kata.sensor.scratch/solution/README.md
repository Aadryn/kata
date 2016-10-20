# Kata - .Net  - Sensor
## Description :
This Kata aims to implement the behavior of an alarm that retrieves a sensor's data.
Your goal is to respect the rules describe below.

### Global Rules :
1. The system under test is the **Alarm** class.
2. No extra fields, properties, methods, indexers, can be added to the **Sensor** class.

### Alarm Behavior rules :
1. When the **Alarm** is initialized the **Status** must be **off**.
2. When the **Check** method of the **Alarm** is called and sensor value is below -21 the **Status** must be **on**.
3. When the **Check** method of the **Alarm** is called and sensor value is past 21 the **Status** must be **on**.
4. When the **Check** method of the **Alarm** is called and sensor is between -21 and 21 the **Status** must be **off**.

## Solution Organization :
* __(Solution)__ kata.sensor.scratch :
	* __(Project)__ kata.sensor.scratch : Regroups all the classes who implement the behaviors.
	* __(Project)__ kata.sensor.scratch.tests : Regroups all the test classes who implement the behaviors
