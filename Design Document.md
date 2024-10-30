# HealthWatch 360

Rhiannon Wallace, Sam Moushey, Megha Pawar, Bengeo George, Sahana Sathiyanarayanan

<hr>

## Introduction

HealthWatch 360 is a mobile application that helps individuals monitor and improve their overall health and wellness.  

By integrating health risk statistics and nutritional data, HealthWatch 360 enables users to:
* Track lifestle habits
* Assess potential health risks
* Receive personalized healthcare recommendations
  
The app is designed for those looking to take control of their health with data-driven insights, empowering users to make better lifestyle choices and prevent common health issues like heart disease, diabetes, and obesity. 

## Logo
<img src="healthcare.png" alt="HealthWatch Logo" width="100" height="100">

## Story Board

1. Home Screen: Displays an overview of the user's health data, including nutrition intake, activity levels, and key health metrics. 
2. Health Risk Analysis: A dashboard where users can view health risk assessments based on their data and local health statistics from CDC. 
3. Nutrition Tracker: Allows users to log their meals and receive recommendations based on USDA food data. 
4. Exercise & Activity Tracking: Users can log daily exercise and track their activity levels. 
5. Health Reports: Users can generate weekly or monthly reports on their health and progress toward goals. 

<img src="Home.png" alt="Home page"> <img src="Nutrition.png" alt="Food page"> <img src="Activities.png" alt="Exercise page"> <img src="Reports.png" alt="Reports page"> <img src="Settings.png" alt="Settings page">

## Requirements
### Requirement #1: Tracking Daily Nutrition
*As a user, I want to track my nutritional intake so I can monitor my health more efficiently.*

#### Dependencies:
* User authentification for personal meal tracking
* USDA FoodData Central API data available and accessible
* Ability to allow for easy search and logging of meals
  
#### Assumptions:
* USDA API provides up-to-date and accurate nutritional data
* USDA API provides a sufficient coverage of food items applicable to users

##### Examples:
1.1<br/>
**Given** the user is logged in, <br/>
**When** the user logs a meal or snack, <br/>
**Then** the app should automatically calculate the total calories and nutrient for the day using the USDA API as its source.

2.1 <br/>
**Given** the user is tracking their food intake, <br/>
**When** the daily sodium level exceeds the recommended amount, <br/>
**Then** the app will display a notification that the user should reduce their sodium intake to better manage their health.

### Requirement #2:
*As a user, I want to receive a personalized health risk assessment so I can better understand my health.*

#### Dependencies:
* Access to CDC Health Data for region-specific health risk information

#### Assumptions:
*

#### Examples:
1.1 <br/>
**Given**  <br/>
**When**  <br/>
**Then**


### Requirement #3:
*As a user, I want to track my physical activity so that I can see how my exercise habits impact my health.*

#### Dependencies:
* Syncing with third-party devices, such as smart watches, to log activities automatically
* User input of exercises into activity logging system

#### Assumptions:
* User will either manually log exercises or will have a compatible device that will automatically log exercises

#### Examples:
1.1 <br/>
**Given**  <br/>
**When**  <br/>
**Then**


### Requirement #4:
*As a user,...*

#### Dependencies:
*

#### Assumptions:
*

#### Examples:
1.1 <br/>
**Given**  <br/>
**When**  <br/>
**Then**


### Requirement #5:
*As a user,...*

#### Dependencies:
*

#### Assumptions:
*

#### Examples:
1.1 <br/>
**Given**  <br/>
**When**  <br/>
**Then**

## Data Sources

[CDC Health Data](https://data.cdc.gov/)  
[USDA FoodData Central]([https://fdc.nal.usda.gov/fdc-app.html#/food-search?type=Foundation&query=](https://fdc.nal.usda.gov/download-datasets.html))

## Development Team
- Rhiannon Wallace
- Sam Moushey
- Megha Pawar
- Bengeo George
- Sahana Sathiyanarayanan

## Meeting Schedule
* Semester: Fall 2024 - Flex II
* Meeting Time & Location: Mondays at 1:00pm via Microsoft Teams


