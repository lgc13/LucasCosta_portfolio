const CodeExampleForInterview = () => {
    const { someId: id } = useParams<{ someId: UUID; }>();

    const { data: thisInformation } = useSomeInformation(id);
    const { data: someInformations = [], isSuccess } = useSomeInformations();
    const breadCrumbRoutes = useAdminBreadCrumbRoutes();

    const [selectedFramework, setSelectedFramework] =
        useState<Framework>();
    const [acceptedMappings, setAcceptedMappings] = useState<
        Mappings[]
    >([]);
    const [form] = Form.useForm();

    return !isSuccess ? (
        <Loading />
    ) : (
        <AdminTabContainer
            data-testid="title-container"
            className={'section'}
            title={`Crosswalk: ${thisInformation?.name}`}
            routes={breadCrumbRoutes.CROSSWALK(thisInformation?.name)}
        >
            {someInformations && someInformations.length > 0 ? (
                <StepWizard
                    isHashEnabled
                    nav={<CrosswalkNav acceptedMappings={acceptedMappings} />}
                    onStepChange={({ activeStep }) => {
                        if (activeStep === 1) {
                            setSelectedFramework(undefined);
                            setAcceptedMappings([]);
                            form.resetFields();
                        }
                    }}
                >
                    <SelectFrameworkStep
                        someInformations={someInformations}
                        onSelectFramework={setSelectedFramework}
                        thisInformation={thisInformation}
                    />
                    <ApplyTemplateStep
                        toFrameworkId={selectedFramework?.id}
                        setAcceptedMappings={setAcceptedMappings}
                    />
                    <SelectControlMappingsStep
                        selectedFramework={selectedFramework}
                        acceptedMappings={acceptedMappings}la
                        setAcceptedMappings={setAcceptedMappings}
                    />
                    <CreateCrosswalkAssessment
                        acceptedMappings={acceptedMappings}
                        thisInformation={thisInformation}
                        toFramework={selectedFramework}
                        form={form}
                    />
                </StepWizard>
            ) : (
                <div data-testid={'no-someInformations'}>
                    This is a generic error message not showing private company data
                </div>
            )}
        </AdminTabContainer>
    );
}

export default CodeExampleForInterview

// SelectFrameworkStep.tsx
const SelectFrameworkStep = ({
 someInformations,
 onSelectFramework,
 nextStep,
}: SelectFrameworkStepProps) => {
    const {mutate: doStuff} = useDoSomethingWithThisData();

    return (
        <div className={'grid gap-4 grid-cols-3'}>
            {someInformations.map((it) => {
                return (
                    <Card
                        data-testid={`card-framework-${it.id}`}
                        className={'flex flex-col justify-between'}
                        key={it.id}
                        hoverable
                        onClick={() => {
                            onSelectFramework(it);
                            nextStep?.();
                            doStuff({
                                entityType: 'IMPORTANT_DATA',
                                description: `This is an important description`,
                                neededObjects: [
                                    {
                                        _thing1: 'this is a thing',
                                        id: it.id,
                                        extra: it.extraData
                                    },
                                    {
                                        _thing1: 'this is a thing 2',
                                        id: it.id,
                                        extra: it.someOtherExtraData,
                                    },
                                ],
                            });
                        }}
                        actions={[<div>{it.moreStuff} Actions</div>]}
                    >
                        <Card.Meta
                            data-testid={`meta-framework-${it.id}`}
                            title={it.name}
                            description={<FrameworkControlCard framework={it} />}
                        />
                    </Card>
                );
            })}
        </div>
    );
}