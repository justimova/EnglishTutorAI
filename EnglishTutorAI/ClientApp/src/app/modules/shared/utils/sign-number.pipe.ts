import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'signNumber'
})
export class SignNumberPipe implements PipeTransform {

  transform(value: number, ...args: unknown[]): string | number {
    if (value > 0) {
      return `+${value}`;
    }
    return value;
  }

}
