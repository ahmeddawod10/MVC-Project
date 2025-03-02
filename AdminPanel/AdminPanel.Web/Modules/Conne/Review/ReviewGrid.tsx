import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ReviewColumns, ReviewRow, ReviewService } from '../../ServerTypes/Conne';
import { ReviewDialog } from './ReviewDialog';

@Decorators.registerClass('AdminPanel.Conne.ReviewGrid')
export class ReviewGrid extends EntityGrid<ReviewRow> {
    protected getColumnsKey() { return ReviewColumns.columnsKey; }
    protected getDialogType() { return ReviewDialog; }
    protected getRowDefinition() { return ReviewRow; }
    protected getService() { return ReviewService.baseUrl; }
}