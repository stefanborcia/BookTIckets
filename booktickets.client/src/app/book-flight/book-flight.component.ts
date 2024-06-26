import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
@Component({
  selector: 'app-book-flight',
  templateUrl: './book-flight.component.html',
  styleUrl: './book-flight.component.css'
})
export class BookFlightComponent implements OnInit {
  constructor(private route: ActivatedRoute) { }

  flightId: string = 'not loaded'

  ngOnInit(): void {
    this.route.paramMap
      .subscribe(parameter => this.findFlight(parameter.get("flightId")))
  }

  private findFlight = (flightId: string | null) => {
    this.flightId = flightId ?? 'not passed';
  }
}
