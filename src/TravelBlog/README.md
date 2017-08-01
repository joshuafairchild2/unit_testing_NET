### Specs

| Behavior | Example Input | Example Output |
| :-------------     | :------------- | :------------- |
| **All data is persisted in SQL** | User submits data | Data is saved to SQL db |
| **User can submit Locations they have visited** | "Nairobi" | List of locations |
| **User can submit Experiences that occured at those Locations** | "I saw a lion" | List of travel experiences |
| **Experiences are tied to a specific Location by foreign key** | "I saw a lion" | "I saw a lion" FK: "Nairobi" |
| **User can submit people they met/interacted with during an event/at a particular location** | "The Pope" | "The Pope" Location-FK: "Vatican" Event-FK: "Tour of the Vatican" |
| **User can query Events by Location** | Query: Events in "Italy" | "I met the Pope" |
| **User can query People by Events** | Query: People at "Tour of the Vatican" | "The Pope" |
| **User can query People by Location** | Query: People in "Italy" | "The Pope" |
| **User can query Location by People OR Events** | Query: Location by "The Pope" | "Italy" |
