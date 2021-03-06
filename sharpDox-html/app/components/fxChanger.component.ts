import {Component} from '@angular/core';
import {Router, NavigationEnd} from '@angular/router';
import {MappingSubscriber} from 'fsc';

import {StateService} from '../state/StateService';
import {SiteStateChanger} from '../state/SiteStateChanger';

@Component({
    selector: 'sd-fxchanger',
    templateUrl: './templates/fxChanger/fxChanger.html',
    styleUrls: ['./templates/fxChanger/fxChanger.css']
})
export class FxChangerComponent implements MappingSubscriber{
    
    public currentRoute : string;
    public currentPageType : any;
    public currentPageId : string;
    public currentPageTargetFxs : any;
    public selectedTargetFx : string;
    public showCode : boolean;
    
    private subscriberId : number;
    private routeSubscription : any;
    
    constructor(private router : Router,
                private stateService : StateService, 
                private siteStateChanger : SiteStateChanger){ }

    ngOnInit(){    
        this.showCode = sharpDox.projectData.showCode;
        this.subscriberId = this.stateService.stateContainer.registerSubscriber(this);
        this.routeSubscription = this.router.events.subscribe(event => {
            if(event instanceof NavigationEnd){
                if(event.url.startsWith("/type") && event.url.indexOf("/code") == -1){
                    this.currentRoute = "type";
                }
                else if(event.url.indexOf("/code") > -1){
                    this.currentRoute = "code";
                }                              
            }
        });
    }
    
    ngOnDestory(){
        this.stateService.stateContainer.unregisterSubscriber(this.subscriberId);
    }
    
    setTargetFx(data){
        this.siteStateChanger.setSelectedTargetFx(data.target.selectedOptions[0].innerText);
        this.siteStateChanger.resetCurrentPage();
    }
        
    get mappings(){
        return {
            "SiteStateChanger.currentPageTargetFxs" : "currentPageTargetFxs",
            "SiteStateChanger.selectedTargetFx" : "selectedTargetFx",
            "SiteStateChanger.currentPageType" : "currentPageType",
            "SiteStateChanger.currentPageId" : "currentPageId"
        } as { [stateKey:string] : string }
    }
}