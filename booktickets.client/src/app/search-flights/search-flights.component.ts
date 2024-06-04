import { Component } from '@angular/core';

@Component({
  selector: 'app-search-flights',
  templateUrl: './search-flights.component.html',
  styleUrl: './search-flights.component.css'
})
export class SearchFlightsComponent {

  searchResult: FlightRm[] = [
    {
      airline: "American Airlines", remainingNumberOfSeats: 500, departure: { time: Date.now().toString(), place: "Los Angeles" },
      arrival: { time: Date.now().toString(), place: "Istanbul" }, price: "350",
    },
    {
      airline: "Delta Airlines",
      remainingNumberOfSeats: 450,
      departure: { time: Date.now().toString(), place: "New York" },
      arrival: { time: Date.now().toString(), place: "Paris" },
      price: "400"
    },
    {
      airline: "United Airlines",
      remainingNumberOfSeats: 300,
      departure: { time: Date.now().toString(), place: "Chicago" },
      arrival: { time: Date.now().toString(), place: "London" },
      price: "500"
    },
    {
      airline: "Southwest Airlines",
      remainingNumberOfSeats: 200,
      departure: { time: Date.now().toString(), place: "Houston" },
      arrival: { time: Date.now().toString(), place: "Toronto" },
      price: "250"
    },
    {
      airline: "JetBlue Airways",
      remainingNumberOfSeats: 350,
      departure: { time: Date.now().toString(), place: "San Francisco" },
      arrival: { time: Date.now().toString(), place: "Tokyo" },
      price: "600"
    },
    {
      airline: "Alaska Airlines",
      remainingNumberOfSeats: 180,
      departure: { time: Date.now().toString(), place: "Seattle" },
      arrival: { time: Date.now().toString(), place: "Beijing" },
      price: "700"
    },
    {
      airline: "Spirit Airlines",
      remainingNumberOfSeats: 220,
      departure: { time: Date.now().toString(), place: "Miami" },
      arrival: { time: Date.now().toString(), place: "Dubai" },
      price: "550"
    },
    {
      airline: "Frontier Airlines",
      remainingNumberOfSeats: 160,
      departure: { time: Date.now().toString(), place: "Denver" },
      arrival: { time: Date.now().toString(), place: "Munich" },
      price: "450"
    },
    {
      airline: "Hawaiian Airlines",
      remainingNumberOfSeats: 100,
      departure: { time: Date.now().toString(), place: "Honolulu" },
      arrival: { time: Date.now().toString(), place: "Sydney" },
      price: "800"
    },
    {
      airline: "Allegiant Air",
      remainingNumberOfSeats: 90,
      departure: { time: Date.now().toString(), place: "Las Vegas" },
      arrival: { time: Date.now().toString(), place: "Amsterdam" },
      price: "650"
    }
  ]
}

export interface FlightRm {
  airline: string;
  arrival: TimePlaceRm;
  departure: TimePlaceRm;
  price: string;
  remainingNumberOfSeats: number;
}

export interface TimePlaceRm {
  place: string;
  time: string;
}
