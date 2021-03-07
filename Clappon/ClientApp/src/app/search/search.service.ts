import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable, of } from 'rxjs';

export interface Device {
  deviceName: string;
  deviceImageUrl: string;
  deviceIndex: number
}

@Injectable({
  providedIn: 'root'
})
export class SearchService {
  private searchResult = new BehaviorSubject<Device[]>([]);
  searchResult$ = this.searchResult.asObservable();

  constructor() { }

  search(searchText: string): Observable<Device[]> {
    const result: Device[] = [
      {
        deviceImageUrl: 'http://www.pngall.com/wp-content/uploads/4/Mobile-Background-PNG-Image.png',
        deviceIndex: 7,
        deviceName: "Galaxy S1"
      },
      {
        deviceImageUrl: 'http://www.pngall.com/wp-content/uploads/4/Mobile-Background-PNG-Image.png',
        deviceIndex: 8,
        deviceName: "Galaxy S2"
      },
      {
        deviceImageUrl: 'http://www.pngall.com/wp-content/uploads/4/Mobile-Background-PNG-Image.png',
        deviceIndex: 9,
        deviceName: "Galaxy S3"
      },
      {
        deviceImageUrl: 'http://www.pngall.com/wp-content/uploads/4/Mobile-Background-PNG-Image.png',
        deviceIndex: 10,
        deviceName: "Nokia"
      },
      {
        deviceImageUrl: 'http://www.pngall.com/wp-content/uploads/4/Mobile-Background-PNG-Image.png',
        deviceIndex: 5,
        deviceName: "Oppo"
      },
      {
        deviceImageUrl: 'http://www.pngall.com/wp-content/uploads/4/Mobile-Background-PNG-Image.png',
        deviceIndex: 7,
        deviceName: "One plus 9"
      }
    ];
    this.searchResult.next(result);
    return of(result);
  }
}
