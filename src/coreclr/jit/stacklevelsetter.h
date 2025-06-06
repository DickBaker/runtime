// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#pragma once

#include "compiler.h"
#include "phase.h"

class StackLevelSetter final : public Phase
{
public:
    StackLevelSetter(Compiler* compiler);

    virtual PhaseStatus DoPhase() override;

private:
    void ProcessBlocks();
    void ProcessBlock(BasicBlock* block);

    void SetThrowHelperBlocks(GenTree* node, BasicBlock* block);
    void SetThrowHelperBlock(SpecialCodeKind kind, BasicBlock* block);

    unsigned PopArgumentsFromCall(GenTreeCall* call);
    void     AddStackLevel(unsigned value);
    void     SubStackLevel(unsigned value);

    void CheckArgCnt();
    void CheckAdditionalArgs();

private:
    unsigned currentStackLevel; // current number of stack slots used by arguments.
    unsigned maxStackLevel;     // max number of stack slots for arguments.

    CompAllocator memAllocator;

    typedef JitHashTable<GenTreePutArgStk*, JitPtrKeyFuncs<GenTreePutArgStk>, unsigned> PutArgNumSlotsMap;
    PutArgNumSlotsMap putArgNumSlots;        // The hash table keeps stack slot sizes for active GT_PUTARG_STK nodes.
    bool              throwHelperBlocksUsed; // Were any throw helper blocks requested for this method.

#if !FEATURE_FIXED_OUT_ARGS
    bool framePointerRequired; // Is frame pointer required based on the analysis made by this phase.
#endif                         // !FEATURE_FIXED_OUT_ARGS
};
