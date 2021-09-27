import { Directive, ElementRef, HostListener, Input, OnInit } from '@angular/core';

@Directive({
  selector: '[appBackground]'
})
export class BackgroundDirective implements OnInit {

  @Input() color!: string;

  constructor(private el: ElementRef) { }

  ngOnInit() {
    this.el.nativeElement.style.backgroundColor = this.color;
  }

  @HostListener('mouseover')
  onMouseOver() {
    this.el.nativeElement.style.backgroundColor = 'blue';
  }

  @HostListener('mouseout')
  onMouseOut() {
    this.el.nativeElement.style.backgroundColor =  'white';
  }
}
