﻿import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { ReviewRow } from "./ReviewRow";

export namespace ReviewService {
    export const baseUrl = 'Conne/Review';

    export declare function Create(request: SaveRequest<ReviewRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<ReviewRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ReviewRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<ReviewRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ReviewRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<ReviewRow>>;

    export const Methods = {
        Create: "Conne/Review/Create",
        Update: "Conne/Review/Update",
        Delete: "Conne/Review/Delete",
        Retrieve: "Conne/Review/Retrieve",
        List: "Conne/Review/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>ReviewService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}