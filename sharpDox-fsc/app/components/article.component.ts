import {Component, Input} from 'angular2/core';
import {RouteParams} from 'angular2/router';

import {ContentBase} from '../ContentBase';
import {StateService} from '../state/StateService';
import {SiteStateChanger} from '../state/SiteStateChanger';

@Component({
    selector: 'sd-article',
    templateUrl: '/templates/content/article/article.html',
    styleUrls: ['./templates/content/article/article.css']
})
export class ArticleComponent extends ContentBase { 
           
    public currentPageData : any = {};
    
    constructor(private _routeParams : RouteParams, 
                private _siteStateChanger : SiteStateChanger,
                _stateService : StateService){ 
        super("sd-article", _stateService);      
    }
    
    notify(state){
        this.currentPageData = state.get("SiteStateChanger.currentPageData");
    }
    
    ngOnInit(){        
        let id = this._routeParams.get('id');
        this._siteStateChanger.setCurrentPageToArticle(id);     
    }
    
}