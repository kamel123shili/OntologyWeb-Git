using Nest;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Smart_Cities.Models
{
    public class Ontologie
    {
        [XmlRoot(ElementName = "Ontology", Namespace = "http://www.semanticweb.org/a/ontologies/2022/9/saafinesrine-ontology-100")]
        public class Ontology
        {
            [XmlElement(ElementName = "Declaration")]
            public Declaration[] Declarations { get; set; }

            [XmlElement(ElementName = "Prefix")]
            public Prefix[] Prefixes { get; set; }

            [XmlElement(ElementName = "SubClassOf")]
            //public SubClassOf[] SubClassOf { get; set; }
            public List<SubClassOf> SubClassOf { get; set; } // Change from SubClassOf[] to List<SubClassOf>

            [XmlElement(ElementName = "Class")]
            public Class[] Class { get; set; }
        }

        // Define SubClassOf outside of Ontologie class
        public class SubClassOf
        {
            [XmlElement(ElementName = "Class")]
            public List<Class> Classes { get; set; }
        }

        // Define Class outside of Ontologie class
        public class Class
        {
            [XmlAttribute(AttributeName = "IRI")]
            public string IRI { get; set; }
        }
        public class Declaration
        {
            [XmlElement(ElementName = "Class")]
            public Class Class { get; set; }

            [XmlElement(ElementName = "ObjectProperty")]
            public ObjectProperty ObjectProperty { get; set; }

            [XmlElement(ElementName = "NamedIndividual")]
            public NamedIndividual NamedIndividual { get; set; }
        }

        class Program
        {
            static void Main(string[] args)
            {
                var ontology = new Ontology
                {
                    SubClassOf = new List<SubClassOf>
                    {
                        new SubClassOf
                        {
                            Classes = new List<Class>
                            {
                                new Class { IRI = OntologyConstants.AccidentIRI },
                                new Class { IRI = OntologyConstants.VehicleIncidentIRI }
                            }
                        },
                        new SubClassOf
                        {
                            Classes = new List<Class>
                            {
                                new Class { IRI = OntologyConstants.AcousticArraySensorIRI },
                                new Class { IRI = OntologyConstants.NonIntrusiveSensorsIRI }
                            }
                        },
                        new SubClassOf
                        {
                            Classes = new List<Class>
                            {
                                new Class { IRI = OntologyConstants.AdultPedestrianIRI },
                                new Class { IRI = OntologyConstants.PedestrianIRI }
                            }
                        },
                        new SubClassOf
                        {
                            Classes = new List<Class>
                            {
                                new Class { IRI = OntologyConstants.AmbulanceIRI },
                                new Class { IRI = OntologyConstants.PriorityVehicleIRI }
                            }
                        },
                        new SubClassOf
                        {
                            Classes = new List<Class>
                            {
                                new Class { IRI = OntologyConstants.ArrivalIRI },
                                new Class { IRI = OntologyConstants.TrajectoryIRI }
                            }
                        },
                        new SubClassOf
                        {
                            Classes = new List<Class>
                            {
                                new Class { IRI = OntologyConstants.AudibleLineIRI },
                                new Class { IRI = OntologyConstants.RoadMarkingsIRI }
                            }
                        },
                        new SubClassOf
                        {
                            Classes = new List<Class>
                            {
                                new Class { IRI = OntologyConstants.AutomatedGuidedVehicleIRI },
                                new Class { IRI = OntologyConstants.MotorisedVehicleIRI }
                            }
                        }
                    }
                };

                // Serialization XML for testing
                XmlSerializer serializer = new XmlSerializer(typeof(Ontology));
                serializer.Serialize(Console.Out, ontology);
            }
        }
    }

    public class Prefix
    {
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "IRI")]
        public string IRI { get; set; }
    }

    public class Accident
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Acoustic_array_Sensor
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Adult_Pedestrian
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Ambulance
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Arrival
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Audible_Line
    {
        // Ajoutez d'autres propriétés si nécessaire
    }
    public class Automated_Guided_Vehicle
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Auxilary_Lane
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Bicycle
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Bridge
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Bus
    {
        // Ajoutez d'autres propriétés si nécessaire
    }
    public class Bus_Station
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Car
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Caravan
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Charging_Station
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Child_Pedestrian
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Dedicated_Lane
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Departure
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Disabled_Vehicle
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Dividing_Line
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Driver
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Edge_Line
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Express_Lane
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Extreme_Weather_Conditions
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Fire_Truck
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Gas_Station
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Green_Sign
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Heavy_Weights_Vehicle
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Hospital_Departure
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class In_Vehicle_Sensors
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Incident
    {
        // Ajoutez d'autres propriétés si nécessaire
    }
    public class Inductive_loop_sensors
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Infrared
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Infrastructure
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Infrastructure_Sensors
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Intrusive_Sensors
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Kerb_Line
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Lane
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Local_Road
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Location
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Manifestation_Event
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Manifestation_Events
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Market_Departure
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Motor_Bike
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Motorised_Vehicle
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class National_Highway
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class National_Road
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Non_Intrusive_Sensors
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Non_Motorised_Vehicle
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Non_Paved_Road
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Non_Recurrent_Incident
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Old_Pedestrian
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Parking_Space
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Passing_Lane
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Passive_Magnetic_Sensors
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Paved_Road
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Peak_Hours
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Pedestrian
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Person
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Pneumatic_Tube_Sensors
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Police_Car
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Priority_Vehicle
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Private_Space
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Private_Vehicle
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Public_Parking_Space
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Public_Vehicle
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Radar
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Recreational_Vehicle
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Recurrent_Incident
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Red_Sign
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Regional_Road
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Regulatory_Sign
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Repair_Works
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Reversible_Lane
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Road
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Road_Intersection
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Road_Markings
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Road_Tunnel
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Roundabout
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class School_Departure
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Semi_Trailer
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Semi_Trailor_Tractor
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Sensors
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Sidewalks
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Sign
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Sport_Event
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Station
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Taxi
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Theft
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Tractor_Truck
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Traffic_Agent_Controller
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Traffic_Light
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Trailer
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Trailer_Tractor
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Trajectory
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Trucks
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Turn_Lane
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Ultrasonic
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Vehicle
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Vehicle_Incident
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class VideoCamera
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Vulnerable_Pedestrian
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Warming_Sign
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Yellow_Sign
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public class Informative_Sign
    {
        // Ajoutez d'autres propriétés si nécessaire
    }

    public static class ObjectProperties
    {
        public const string Circulates = "#Circulates";
        public const string Detects = "#Detects";
        public const string Drives = "#Drives";
        public const string EquippedBy = "#EquippedBy";
        public const string HappensIn = "#HappensIn";
        public const string HasEndPoint = "#HasEndPoint";
        public const string HasPosition = "#HasPosition";
        public const string HasProperty = "#HasProperty";
        public const string HasStartPoint = "#HasStartPoint";
        public const string HasTimeStamp = "#HasTimeStamp";
        public const string HasValue = "#HasValue";
        public const string InstalledIn = "#InstalledIn";
        public const string IsArrangedIn = "#IsArrangedIn";
        public const string IsDetectedBy = "#IsDetectedBy";
        public const string IsHostedBy = "#IsHostedBy";
        public const string IsObservedBy = "#IsObservedBy";
        public const string IsPropertyOf = "#IsPropertyOf";
        public const string Observes = "#Observes";
        public const string Posseses = "#Posseses";
        public const string Hosts = "#hosts";

    }

    public class NamedIndividual
    {
        [XmlAttribute(AttributeName = "IRI")]
        public string IRI { get; set; }

        [XmlText]
        public string Name { get; set; }
    }
    public static class NamedIndividuals
    {
        public const string A1_Tunis_Sousse_Sfax_Gabes = "#A1_Tunis_Sousse_Sfax_Gabes";
        public const string A3_Tunis_Beja_Bouslem = "#A3_Tunis_Beja_Bouslem";
        public const string A4_Tunis_Bizerte = "#A4_Tunis_Bizerte";
        public const string AMR = "#AMR";
        public const string AMR_LINEAR_LOW_FIELD_SENSOR = "#AMR_LINEAR_LOW_FIELD_SENSOR";
        public const string AMR_POSITION_SENSORS = "#AMR_POSITION_SENSORS";
        public const string Air_flow_sensor = "#Air-flow_sensor";
        public const string Ariana_Roundabout = "#Ariana_Roundabout";
        public const string Bab_Bhar_Roundabout = "#Bab_Bhar_Roundabout";
        public const string Bab_El_jedid_Parking = "#Bab_El_jedid_Parking";
        public const string Bab_El_khadhra_Parking = "#Bab_El_khadhra_Parking";
        public const string Bab_Saadoun_Roundabout = "#Bab_Saadoun_Roundabout";
        public const string Bab_Saadoun_Tunnel = "#Bab_Saadoun_Tunnel";
        public const string Bab_Souika_Tunnel = "#Bab_Souika_Tunnel";
        public const string Bardo_Tunnel = "#Bardo_Tunnel";
        public const string Bizerta_Transporter_Bridge = "#Bizerta_Transporter_Bridge";
        public const string Bizerte_Bascule_Bridge = "#Bizerte_Bascule_Bridge";
        public const string CO_KMT37_SO8_ANGLE_ANALOG = "#CO_KMT37_SO8_ANGLE_ANALOG";
        public const string Camshaft_position_sensor = "#Camshaft_position_sensor";
        public const string Charguia1_Bus_Stop = "#Charguia1_Bus_Stop";
        public const string DL1 = "#DL1";
        public const string DL10 = "#DL10";
        public const string DL2 = "#DL2";
        public const string DL3 = "#DL3";
        public const string DL4 = "#DL4";
        public const string DL5 = "#DL5";
        public const string DL6 = "#DL6";
        public const string DL7 = "#DL7";
        public const string DL8 = "#DL8";
        public const string DL9 = "#DL9";
        public const string Djerba_Zarzis_Bridge = "#Djerba_Zarzis_Bridge";
        public const string EL1 = "#EL1";
        public const string EL10 = "#EL10";
        public const string EL2 = "#EL2";
        public const string EL3 = "#EL3";
        public const string EL4 = "#EL4";
        public const string EL5 = "#EL5";
        public const string EL6 = "#EL6";
        public const string EL7 = "#EL7";
        public const string EL8 = "#EL8";
        public const string EL9 = "#EL9";
        public const string El_Menzah1_Bus_Stop = "#El_Menzah1_Bus_Stop";
        public const string El_Menzah2_Bus_Stop = "#El_Menzah2_Bus_Stop";
        public const string El_Menzah8_Bus_Stop = "#El_Menzah8_Bus_Stop";
        public const string Engine_knock_sensor = "#Engine_knock_sensor";
        public const string Engine_speed_sensor = "#Engine_speed_sensor";
        public const string Enkhilet_Bus_Stop = "#Enkhilet_Bus_Stop";
        public const string Ennasr_Bus_Stop = "#Ennasr_Bus_Stop";
        public const string Ennasr_City_Roundabout = "#Ennasr_City_Roundabout";
        public const string Fifth_Bridge = "#Fifth_Bridge";
        public const string GMR = "#GMR";
        public const string Gammart_Roundabout = "#Gammart_Roundabout";
        public const string Garden_Habib_Themeur_Bus_Stop = "#Garden_Habib_Themeur_Bus_Stop";
        public const string Habib_Bourguiba_Roundabout = "#Habib_Bourguiba_Roundabout";
        public const string Hall_effect = "#Hall_effect";
        public const string HomeCharger_Charging_Station_27_Rue_Abou_Loubéba_Al_Ansari_Ariana_7102 = "#HomeCharger_Charging_Station_27_Rue_Abou_Loubéba_Al_Ansari_Ariana_7102";
        public const string KMT36H_TDFN_ROHS = "#KMT36H_TDFN_ROHS";
        public const string KMT_32B_TDFN_ROHS = "#KMT_32B_TDFN_ROHS";
        public const string LC10_1_D_230_VAC = "#LC10-1-D_230_VAC";
        public const string LC10_1_D_24_VDC = "#LC10-1-D_24_VDC";
        public const string LC20_1_DR_230VAC = "#LC20-1-DR_230VAC";
        public const string LC20_1_RB_230VAC = "#LC20-1-RB_230VAC";
        public const string LC20_2_DR_230VAC = "#LC20-2-DR_230VAC";
        public const string LC20_2_RB_230VAC = "#LC20-2-RB_230VAC";
        public const string LC20_DT = "#LC20-DT";
        public const string Lac1_Roundabout = "#Lac1_Roundabout";
        public const string Marsa_Roundabout = "#Marsa_Roundabout";
        public const string Medjez_El_Beb_Bridge = "#Medjez_El_Beb_Bridge";
        public const string Mornag_Bus_stop = "#Mornag_Bus_stop";
        public const string Oxygen_sensor = "#Oxygen_sensor";
        public const string PL1 = "#PL1";
        public const string PL10 = "#PL10";
        public const string PL2 = "#PL2";
        public const string PL3 = "#PL3";
        public const string PL4 = "#PL4";
        public const string PL5 = "#PL5";
        public const string PL6 = "#PL6";
        public const string PL7 = "#PL7";
        public const string PL8 = "#PL8";
        public const string PL9 = "#PL9";
        public const string Paid_Parking_Madina_Bab_Bhar = "#Paid_Parking_Madina_Bab_Bhar";
        public const string Parking_Avenue_De_Jassmine = "#Parking_Avenue_De_Jassmine";
        public const string Parking_Avenue_Habib_Bourguiba = "#Parking_Avenue_Habib_Bourguiba";
        public const string Parking_Bab_Laasal = "#Parking_Bab_Laasal";
        public const string Parking_El_Kasbah = "#Parking_El_Kasbah";
        public const string Parking_Ezouhour = "#Parking_Ezouhour";
        public const string Parking_Lac = "#Parking_Lac";
        public const string Parking_Mohammed_V = "#Parking_Mohammed_V";
        public const string Parking_Mokthar_Attia = "#Parking_Mokthar_Attia";
        public const string Parking_Mon_Plaisir = "#Parking_Mon_Plaisir";
        public const string Parking_Palace = "#Parking_Palace";
        public const string Parking_Sinen_Pecha = "#Parking_Sinen_Pecha";
        public const string Parking_Tunis_City = "#Parking_Tunis_City";
        public const string Parking_minicipal_Ariana = "#Parking_minicipal_Ariana";
        public const string Parking_sensor = "#Parking_sensor";
        public const string Place_Pasteur_Bus_Stop = "#Place_Pasteur_Bus_Stop";
        public const string Porsche_Destination_Charging_Station_2045_N9_Tunis = "#Porsche_Destination_Charging_Station_2045_N9_Tunis";
        public const string Porsche_Destination_Charging_Station_70_Rue_8603_ChargingStation = "#Porsche_Destination_Charging_Station_70_Rue_8603_ChargingStation";
        public const string Public_Parking_Marsa = "#Public_Parking_Marsa";
        public const string RL1 = "#RL1";
        public const string RL10 = "#RL10";
        public const string RL2 = "#RL2";
        public const string RL3 = "#RL3";
        public const string RL349 = "#RL349";
        public const string RL350 = "#RL350";
        public const string RL351 = "#RL351";
        public const string RL352 = "#RL352";
        public const string RL353 = "#RL353";
        public const string RL354 = "#RL354";
        public const string RL355 = "#RL355";
        public const string RL356 = "#RL356";
        public const string RL357 = "#RL357";
        public const string RL358 = "#RL358";
        public const string RL4 = "#RL4";
        public const string RL5 = "#RL5";
        public const string RL6 = "#RL6";
        public const string RL7 = "#RL7";
        public const string RL8 = "#RL8";
        public const string RL9 = "#RL9";
        public const string RN1 = "#RN1";
        public const string RN10 = "#RN10";
        public const string RN2 = "#RN2";
        public const string RN3 = "#RN3";
        public const string RN4 = "#RN4";
        public const string RN5 = "#RN5";
        public const string RN6 = "#RN6";
        public const string RN7 = "#RN7";
        public const string RN8 = "#RN8";
        public const string RN9 = "#RN9";
        public const string RR21 = "#RR21";
        public const string RR22 = "#RR22";
        public const string RR23 = "#RR23";
        public const string RR24 = "#RR24";
        public const string RR25 = "#RR25";
        public const string RR26 = "#RR26";
        public const string RR27 = "#RR27";
        public const string RR28 = "#RR28";
        public const string RR29 = "#RR29";
        public const string RR30 = "#RR30";
        public const string RR31 = "#RR31";
        public const string Rades_La_Goulette_Bridge = "#Rades_La_Goulette_Bridge";
        public const string Rue_Chabane_El_Bhouri_ChargingStation = "#Rue_Chabane_El_Bhouri_ChargingStation";
        public const string Shell__El_Omrane_Avenue_Belhassen_Ben_Chaabane_1_Av_El_Asyouti__El_Omrane_2073 = "#Shell__El_Omrane_Avenue_Belhassen_Ben_Chaabane_1_Av_El_Asyouti__El_Omrane_2073";
        public const string Smart_Park_P1 = "#Smart_Park_P1";
        public const string Sokra_Roundabout = "#Sokra_Roundabout";
        public const string Station_service_Shell_MC_N_130__Tunis_2042 = "#Station-service_Shell_MC_N_130__Tunis_2042";
        public const string Station_service_Shell_sortie_Ouest_Ii_Gp5__Tunis__2052 = "#Station-service_Shell_sortie_Ouest_Ii_Gp5__Tunis__2052";
        public const string Station_service_TotalEnergies_EL_MENZAH = "#Station-service_TotalEnergies_EL_MENZAH";
        public const string Station_service_TotalEnergies_KHEREDDINE_PACHA = "#Station-service_TotalEnergies_KHEREDDINE_PACHA";
        public const string Station_Service_Ariana = "#Station_Service_Ariana";
        public const string TL1 = "#TL1";
        public const string TL10 = "#TL10";
        public const string TL2 = "#TL2";
        public const string TL3 = "#TL3";
        public const string TL4 = "#TL4";
        public const string TL5 = "#TL5";
        public const string TL6 = "#TL6";
        public const string TL7 = "#TL7";
        public const string TL8 = "#TL8";
        public const string TL9 = "#TL9";
        public const string Temperature_sensor = "#Temperature_sensor";
        public const string Throttle_position_sensor = "#Throttle_position_sensor";
        public const string Tunis_Carthage_Airport_Bus_Stop = "#Tunis_Carthage_Airport_Bus_Stop";
        public const string Tunis_Carthage_Airport_Tunnel = "#Tunis_Carthage_Airport_Tunnel";
        public const string Urban_Nord_Public_Parking = "#Urban_Nord_Public_Parking";
        public const string Voltage_sensor = "#Voltage_sensor";
        public const string Reed_Switch = "#reed_Switch";
        public const string Rue_24_Lac_Huron_ChargingStation = "#24_Rue_Lac_Huron_ChargingStation";
        public const string AGIL_R59M_46R_Ave_Mohamed_V_Tunis = "#AGIL_R59M+46R_Ave_Mohamed_V__Tunis";
        public const string CO_MS32_8L_TDFN_2_5x2_5_SWITCH_ANALOG = "#CO_MS32_8L_TDFN_2,_5x2,_5_SWITCH_ANALOG";
        public const string KMT39_TD_TDFN_ROHS = "#KMT39/TD_TDFN_ROHS";
        public const string LC20_1_DR_12_24VAC_DC = "#LC20-1-DR_12-24VAC/DC";
        public const string LC20_1_RB_12_24VAC_DC = "#LC20-1-RB_12-24VAC/DC";
        public const string LC20_2_DR_12_24VAC_DC = "#LC20-2-DR_12-24VAC/DC";
        public const string LC20_2_RB_12_24VAC_DC = "#LC20-2-RB_12-24VAC/DC";
        public const string Magnetic_Encoders_KMA36 = "#Magnetic_Encoders:_KMA36";
        public const string Manifold_Absolute_Pressure_MAP_sensor = "#Manifold_Absolute_Pressure_(MAP)_sensor";
        public const string OiLibya_R45J_PVX_Tunis = "#OiLibya_R45J+PVX_Tunis";
        public const string Parking_Rue_Lhiver = "#Parking_Rue_L&apos;hiver";
        public const string Porsche_Destination_Charging_Station_Carthage_1_La_Marsa_Gammarth = "#Porsche_Destination_Charging_Station__Carthage,_1_La_Marsa,_Gammarth";
        public const string Porsche_Destination_Charging_Station_R54P_XP4_Rue_Chabane_El_Bhouri = "#Porsche_Destination_Charging_Station__R54P+XP4__Rue_Chabane_El_Bhouri";
        public const string Station_service_Shell_R5CH_9F7_Jeanne_dArc = "#Station-service_Shell_R5CH+9F7_Jeanne_d&apos;Arc";
        public const string Total_Charging_Station_R7X8_P9X_Tunis_ChargingStation = "#Total_Charging_Station_R7X8+P9X,_Tunis_ChargingStation";
        public const string Station_met_ibn_khaldoun_R4JM_8J8_Rue_6673_Tunis = "#station_met_ibn_khaldoun_R4JM+8J8_Rue_6673_Tunis";

    }
    public static class OntologyConstants
    {
        public const string AccidentIRI = "#Accident";
        public const string VehicleIncidentIRI = "#Vehicle_Incident";
        public const string AcousticArraySensorIRI = "#Acoustic_array_Sensor";
        public const string NonIntrusiveSensorsIRI = "#Non_Intrusive_Sensors";
        public const string AdultPedestrianIRI = "#Adult_Pedestrian";
        public const string PedestrianIRI = "#Pedestrian";
        public const string AmbulanceIRI = "#Ambulance";
        public const string PriorityVehicleIRI = "#Priority_Vehicle";
        public const string ArrivalIRI = "#Arrival";
        public const string TrajectoryIRI = "#Trajectory";
        public const string AudibleLineIRI = "#Audible_Line";
        public const string RoadMarkingsIRI = "#Road_Markings";
        public const string AutomatedGuidedVehicleIRI = "#Automated_Guided_Vehicle";
        public const string MotorisedVehicleIRI = "#Motorised_Vehicle";
    }

}
