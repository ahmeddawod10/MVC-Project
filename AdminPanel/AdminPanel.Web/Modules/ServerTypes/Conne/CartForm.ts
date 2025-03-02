import { StringEditor, ServiceLookupEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface CartForm {
    Userid: StringEditor;
    Productid: ServiceLookupEditor;
    Count: IntegerEditor;
    Price: IntegerEditor;
}

export class CartForm extends PrefixedContext {
    static readonly formKey = 'Conne.Cart';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CartForm.init)  {
            CartForm.init = true;

            var w0 = StringEditor;
            var w1 = ServiceLookupEditor;
            var w2 = IntegerEditor;

            initFormType(CartForm, [
                'Userid', w0,
                'Productid', w1,
                'Count', w2,
                'Price', w2
            ]);
        }
    }
}