import { Injectable } from '@angular/core';
import * as altertify from 'alertifyjs';
import { stringify } from '@angular/compiler/src/util';

@Injectable({
  providedIn: 'root'
})
export class AltertifyService {
  constructor() {}
  confirm(message: string, okCallback: () => any) {
    altertify.confirm(message, (e: any) => {
      if (e) {
        okCallback();
      } else {
      }
    });
  }
  success(message: string) {
    altertify.success(message);
  }
  error(message: string) {
    altertify.error(message);
  }
  warning(message: string) {
    altertify.warning(message);
  }
  message(message: string) {
    altertify.message(message);
  }
}
